using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAcess.Repository.IRepository
{
    public interface IRepositoryAsync<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<T> GetByIdAsync(Guid id);
        Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter = null);
        Task<T> GetFirstOrDefaultAsync<TProperity>(Expression<Func<T, bool>> filter = null, Expression<Func<T, TProperity>> navigationProperityPath = null);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter = null);
        Task<IEnumerable<T>> GetAllAsync<TProperity>(Expression<Func<T, bool>> filter = null, Expression<Func<T, TProperity>> navigationProperityPath = null);

        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Remove(int id);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
