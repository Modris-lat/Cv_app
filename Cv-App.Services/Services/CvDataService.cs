using System.Collections.Generic;
using System.Threading.Tasks;
using Cv_App.Core.Models;
using Cv_App.Data.Interfaces;
using Cv_App.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cv_App.Services.Services
{
    public class CvDataService: EntityService<CvModel>, ICvDataService
    {
        private readonly ICvAppContext _ctx;
        public CvDataService(ICvAppContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }

        public async Task<CvModel> GetCvModelAsync(int id)
        {
            return await _ctx.CvModels
                .Include(x => x.PersonalData)
                .Include(y => y.Educations)
                .Include(s => s.WorkExperiences)
                .Include(l => l.Properties)
                .AsNoTracking()
                .FirstOrDefaultAsync(o => o.Id == id);
        }

        public IEnumerable<CvModel> GetAllCvData()
        {
            return _ctx.CvModels
                .Include(p => p.PersonalData)
                .Include(e => e.Educations)
                .Include(w => w.WorkExperiences)
                .Include(p => p.Properties)
                .AsNoTracking();
        }
    }
}
