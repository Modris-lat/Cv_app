using Cv_App.Core.Models;
using Cv_App.Data.Interfaces;
using Cv_App.Services.Interfaces;

namespace Cv_App.Services.Services
{
    public class CvDataService: EntityService<CvModel>, ICvDataService
    {
        private readonly ICvAppContext _ctx;
        public CvDataService(ICvAppContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }
    }
}
