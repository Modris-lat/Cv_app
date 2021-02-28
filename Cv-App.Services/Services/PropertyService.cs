using Cv_App.Core.Models;
using Cv_App.Data.Interfaces;
using Cv_App.Services.Interfaces;

namespace Cv_App.Services.Services
{
    public class PropertyService: EntityService<Property>, IPropertyService
    {
        public PropertyService(ICvAppContext ctx) : base(ctx)
        {
        }
    }
}
