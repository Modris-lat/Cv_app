using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cv_App.Core.Interfaces;
using Cv_App.Core.Models;
using Cv_App.Core.Services;
using Cv_App.Data.Interfaces;

namespace Cv_App.Services.Services
{
    public class EntityService<T>: DbService, IEntityService<T> where T: Entity
    {
        public EntityService(ICvAppContext ctx) : base(ctx)
        {
        }
        public IQueryable<T> Query()
        {
            return Query<T>();
        }

        public IQueryable<T> QueryById(int id)
        {
            return QueryById<T>(id);
        }

        public IEnumerable<T> Get()
        {
            return Get<T>();
        }

        public Task<T> GetById(int id)
        {
            return GetById<T>(id);
        }

        public ServiceResult Create(T entity)
        {
            return Create<T>(entity);
        }

        public ServiceResult Delete(T entity)
        {
            return Delete<T>(entity);
        }

        public ServiceResult Update(T entity)
        {
            return Update<T>(entity);
        }

        public ServiceResult ClearAll()
        {
            return ClearAll<T>();
        }

        public bool Exists(int id)
        {
            return Exists<T>(id);
        }
    }
}
