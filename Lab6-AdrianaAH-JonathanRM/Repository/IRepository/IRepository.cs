﻿using System.Linq.Expressions;

namespace Lab6_AdrianaAH_JonathanRM.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(string? includeProperties = null);

        T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null);

        void Add(T entity);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);

    }
}
