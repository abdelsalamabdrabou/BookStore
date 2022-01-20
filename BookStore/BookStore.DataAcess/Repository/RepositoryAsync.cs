using BookStore.Data;
using BookStore.DataAcess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAcess.Repository
{
    public class RepositoryAsync<T> : IRepositoryAsync<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        private IQueryable<T> query;
        internal DbSet<T> dbSet;
        public RepositoryAsync(ApplicationDbContext db)
        {
            _db = db;
            dbSet = _db.Set<T>();
            query = dbSet;
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await dbSet.FindAsync(id);
        }
        public async Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter)
        {
            if (filter != null)
                query = query.Where(filter);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<T> GetFirstOrDefaultAsync<TProperity>(Expression<Func<T, bool>> filter, Expression<Func<T, TProperity>> navigationProperityPath = null)
        {
            if (navigationProperityPath != null)
                query = query.Include(navigationProperityPath);

            if (filter != null) 
                query = query.Where(filter);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter = null)
        {
            if (filter != null)
                query = query.Where(filter);

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync<TProperity>(Expression<Func<T, bool>> filter = null, Expression<Func<T, TProperity>> navigationProperityPath = null)
        {
            if (navigationProperityPath != null)
                query = query.Include(navigationProperityPath);

            if (filter != null)
                query = query.Where(filter);

            return await query.ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await dbSet.AddRangeAsync(entities);
        }

        public void Remove(int id)
        {
            T entity = dbSet.Find(id);
            dbSet.Remove(entity);
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            dbSet.RemoveRange(entities);
        }
    }
}
