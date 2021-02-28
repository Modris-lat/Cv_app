using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cv_App.Core.Interfaces;
using Cv_App.Core.Models;
using Cv_App.Core.Services;
using Cv_App.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cv_App.Services.Services
{
    public class DbService: IDbService
    {
        protected readonly ICvAppContext _ctx;

        public DbService(ICvAppContext context)
        {
            _ctx = context;
        }
        
        public IQueryable<T> Query<T>() where T : Entity
        {
            return _ctx.Set<T>().AsQueryable();
        }

        public IQueryable<T> QueryById<T>(int id) where T : Entity
        {
            return _ctx.Set<T>().Where(e => e.Id == id);
        }

        public IEnumerable<T> Get<T>() where T : Entity
        {
            return Query<T>().ToList();
        }

        public async Task<T> GetById<T>(int id) where T : Entity
        {
            return await _ctx.Set<T>().SingleOrDefaultAsync(e => e.Id == id);
        }

        public ServiceResult Create<T>(T entity) where T : Entity
        {
            if (entity == null)
            {
                throw new ArgumentException(nameof(entity));
            }

            _ctx.Set<T>().Add(entity);
            _ctx.SaveChanges();
            return new ServiceResult(true).Set(entity);
        }

        public ServiceResult Delete<T>(T entity) where T : Entity
        {
            if (entity == null)
            {
                throw new ArgumentException(nameof(entity));
            }

            _ctx.Set<T>().Remove(entity);
            _ctx.SaveChanges();
            return new ServiceResult(true);
        }

        public ServiceResult Update<T>(T entity) where T : Entity
        {
            if (entity == null)
            {
                throw new ArgumentException(nameof(entity));
            }

            _ctx.Entry(entity).State = EntityState.Modified;
            _ctx.SaveChanges();
            return new ServiceResult(true).Set(entity);
        }

        public bool Exists<T>(int id) where T : Entity
        {
            return QueryById<T>(id).Any();
        }

        public ServiceResult ClearAll<T>() where T : Entity
        {
            _ctx.Set<T>().RemoveRange(_ctx.Set<T>());
            _ctx.SaveChanges();
            return new ServiceResult(true);
        }
    }
}
