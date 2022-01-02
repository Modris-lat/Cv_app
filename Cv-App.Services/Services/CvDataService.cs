using System.Collections.Generic;
using System.Threading.Tasks;
using Cv_App.Core.Models;
using Cv_App.Core.Services;
using Cv_App.Data.Interfaces;
using Cv_App.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cv_App.Services.Services
{
    public class CvDataService: EntityService<CvModel>, ICvDataService
    {
        public CvDataService(ICvAppContext ctx) : base(ctx)
        {
        }

        public async Task<CvModel> GetCvModelAsync(int id)
        {
            return await Query<CvModel>()
                .Include(x => x.PersonalData)
                .Include(y => y.Educations)
                .Include(s => s.WorkExperiences)
                .Include(l => l.Properties)
                .AsNoTracking()
                .FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task<IEnumerable<CvModel>> GetAllCvData()
        {
            return await Query<CvModel>()
                .Include(p => p.PersonalData)
                .Include(e => e.Educations)
                .Include(w => w.WorkExperiences)
                .Include(p => p.Properties)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<ServiceResult> UpdateCv(CvModel cvModel)
        {
            var model = await Query<CvModel>()
                .Include(x => x.PersonalData)
                .Include(y => y.Educations)
                .Include(s => s.WorkExperiences)
                .Include(l => l.Properties)
                .FirstOrDefaultAsync(o => o.Id == cvModel.Id);
            model.CvTitle = cvModel.CvTitle;
            model.PersonalData = cvModel.PersonalData;
            model.Educations = cvModel.Educations;
            model.WorkExperiences = cvModel.WorkExperiences;
            model.Properties = cvModel.Properties;

            return Update(model);
        }
    }
}
