using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cv_App.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Cv_App.Data.Interfaces
{
    public interface ICvAppContext
    {
        DbSet<T> Set<T>() where T : class;
        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
        Task<int> SaveAsync();
        Task EnsureDataBaseCreated();
        DbSet<CvModel> CvModels { get; set; }
        DbSet<Property> Properties { get; set; }
    }
}
