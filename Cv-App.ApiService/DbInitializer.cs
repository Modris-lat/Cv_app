using Cv_App.Data.Interfaces;

namespace Cv_App.ApiService
{
    public static class DbInitializer
    {
        public static void Initialize(ICvAppContext dataContext)
        {
            dataContext.EnsureDataBaseCreated();
        }
    }
}
