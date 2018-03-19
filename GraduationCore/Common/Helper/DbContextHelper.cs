using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using GraduationCore.Common.Interface;
using GraduationCore.Common.Models.DataModels;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GraduationCore.Common.Helper
{
    public class DbContextHelper<T> : IEFRepository<T> where T : class
    {
        #region Singlton
        public static readonly DbContextHelper<T> Instance = new DbContextHelper<T>();
        private DbContextHelper()
        {
            // Create();
        }
        #endregion

        public DbContext Context
        {
            get
            {
                return new GDBContext();
            }
        }
        public bool AddEntity(T entity)
        {
            EntityState state = Context.Entry(entity).State;
            if (state == EntityState.Detached)
            {
                Context.Entry(entity).State = EntityState.Added;
            }
            Context.SaveChanges();
            return true;
        }

        public bool DeleteEntities(IEnumerable entities)
        {
            try
            {
                Context.ChangeTracker.AutoDetectChangesEnabled = false;
                foreach (T entity in entities)
                {
                    DeleteEntity(entity);
                }
                return true;
            }
            finally
            {
                Context.ChangeTracker.AutoDetectChangesEnabled = true;
            }
        }

        public bool DeleteEntity(int id)
        {
            T entity = FindById(id);
            return DeleteEntity(entity);
        }

        public bool DeleteEntity(T entity)
        {
            Context.Set<T>().Attach(entity);
            Context.Entry<T>(entity).State = EntityState.Deleted;
            return Context.SaveChanges() > 0;
        }

        public bool DeleteEntity(Expression<Func<T, bool>> predicate)
        {
            List<T> entities = Set().Where(predicate).ToList();
            return Context.SaveChanges() > 0;
        }

        public T FindById(int id)
        {
            return Set().Find(id);
        }

        public IEnumerable<T> LoadEntities(Func<T, bool> whereLambda)
        {
            if (whereLambda != null)
            {
                return Context.Set<T>().Where<T>(whereLambda).AsQueryable().ToList();
            }
            else
            {
                return Context.Set<T>().AsQueryable().ToList();
            }
        }

        public IEnumerable<T> LoadEntities(int pageIndex = 1, int pageSize = 30, Func<T, bool> whereLambda = null)
        {
            int skinCount = (pageIndex - 1) * pageSize;
            if (whereLambda != null)
            {
                return Set()
                    .Where<T>(whereLambda)
                    .Skip(skinCount)
                    .Take(pageSize)
                    .ToList();

            }
            else
            {
                return Set()
                    .Skip(skinCount)
                    .Take(pageSize)
                    .ToList();
            }
        }

        public bool UpdateEntities(IEnumerable entities)
        {
            try
            {
                Context.ChangeTracker.AutoDetectChangesEnabled = false;
                foreach (T entity in entities)
                {
                    UpdateEntity(entity);
                }
                return true;
            }
            finally
            {
                Context.ChangeTracker.AutoDetectChangesEnabled = true;
            }
        }

        public bool UpdateEntity(T entity)
        {
            Context.Set<T>().Attach(entity);
            Context.Entry<T>(entity).State = EntityState.Modified;
            return Context.SaveChanges() > 0;
        }

        public DbSet<T> Set()
        {
            return Context.Set<T>();
        }
    }
}