using System;
using System.Collections;
using System.Linq.Expressions;
using System.Linq;
using System.Collections.Generic;

namespace GraduationCore.Common.Interface
{
    public interface IEFRepository<T> where T:class
    {
        bool AddEntity(T entity);
        bool UpdateEntity(T entity);
        bool UpdateEntities(IEnumerable entities);
        bool DeleteEntity(int id);
        bool DeleteEntity(T entity);
        bool DeleteEntity(Expression<Func<T,bool>> predicate);
        bool DeleteEntities(IEnumerable entities);
        IEnumerable<T> LoadEntities(Func<T,bool> whereLambda);
        IEnumerable<T> LoadEntities(int pageIndex=1,int pageSize=30,Func<T,bool> whereLambda=null);
        T FindById(int id);
    }
}