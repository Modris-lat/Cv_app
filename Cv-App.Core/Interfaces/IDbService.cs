﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cv_App.Core.Models;
using Cv_App.Core.Services;

namespace Cv_App.Core.Interfaces
{
    public interface IDbService
    {
        IQueryable<T> Query<T>() where T : Entity;
        IQueryable<T> QueryById<T>(int id) where T : Entity;
        IEnumerable<T> Get<T>() where T : Entity;
        Task<T> GetById<T>(int id) where T : Entity;
        ServiceResult Create<T>(T entity) where T : Entity;
        ServiceResult Delete<T>(T entity) where T : Entity;
        ServiceResult Update<T>(T entity) where T : Entity;
        ServiceResult ClearAll<T>() where T : Entity;
        bool Exists<T>(int id) where T : Entity;
    }
}
