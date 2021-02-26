using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
