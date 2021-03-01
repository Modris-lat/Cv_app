using System.Collections.Generic;
using System.Threading.Tasks;
using Cv_App.Core.Interfaces;
using Cv_App.Core.Models;

namespace Cv_App.Services.Interfaces
{
    public interface ICvDataService: IEntityService<CvModel>
    {
        Task<CvModel> GetCvModelAsync(int id);
        IEnumerable<CvModel> GetAllCvData();
    }
}
