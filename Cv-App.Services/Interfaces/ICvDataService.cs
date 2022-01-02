using System.Collections.Generic;
using System.Threading.Tasks;
using Cv_App.Core.Interfaces;
using Cv_App.Core.Models;
using Cv_App.Core.Services;

namespace Cv_App.Services.Interfaces
{
    public interface ICvDataService: IEntityService<CvModel>
    {
        Task<CvModel> GetCvModelAsync(int id);
        Task<IEnumerable<CvModel>> GetAllCvData();
        Task<ServiceResult> UpdateCv(CvModel cvModel);
    }
}
