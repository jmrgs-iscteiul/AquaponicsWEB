using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AquaponicsWebPortal.EntityFramework
{
    public interface IGenericRepository<T> where T : class
    {
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        IEnumerable<T> FindBy(Expression<Func<T, bool>> wherePredicate, params string[] includePredicate);
    }
}
