using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cv_App.Core.Models;
using Cv_App.Core.Services;

namespace Cv_App.Core.Interfaces
{
    public interface IEntityService<T> where T: Entity
    {
        IQueryable<T> Query();
        IQueryable<T> QueryById(int id);
        IEnumerable<T> Get();
        Task<T> GetById(int id);
        ServiceResult Create(T entity);
        ServiceResult Delete(T entity);
        ServiceResult Update(T entity);
        ServiceResult ClearAll();
        bool Exists(int id);
    }
}
