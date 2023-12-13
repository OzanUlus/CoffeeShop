using CoffeeShop.DAL.Abstract;
using CoffeeShop.DAL.Context;
using CoffeeShop.Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAL.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly AppDbContext _appDbContext;
        private readonly DbSet<T> _dbSet;
        private AppDbContext appDbContext;

        public GenericRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public GenericRepository(AppDbContext appDbContext, DbSet<T> dbSet)
        {
            _appDbContext = appDbContext;
            _dbSet = dbSet;
        }

        public async Task AddAsync(T entity)
        {
           await _dbSet.AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            await Task.Run(() => _dbSet.Remove(entity));
            await _appDbContext.SaveChangesAsync();
        }

      

        public async Task<List<T>> GetAllAsync(bool asNoTracking = true, Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbSet;

            if (filter != null) 
            {
              query = query.Where(filter);
            
            }
            if (includeProperties.Any()) 
            {
                foreach (var item in includeProperties)
                {
                    query = query.Include(item);

                }
     
            }
            if (asNoTracking)
            {
                query = query.AsNoTracking();

            }
            var result = await query.ToListAsync();
            return result;
        }

        public async Task<List<T>> GetAllAsync()
        {
          var result =  await _dbSet.ToListAsync();
            return result;
        }

        public async Task<T> GetAsync(bool asNoTracking = true, Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);

            }
            if (includeProperties.Any())
            {
                foreach (var item in includeProperties)
                {
                    query = query.Include(item);

                }

            }
            if (asNoTracking)
            {
                query = query.AsNoTracking();

            }
            var result = await query.SingleAsync();
            return result;
        }

        public async Task GetByIdAsync(string id)
        {
            await _dbSet.FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            await Task.Run(() => _dbSet.Update(entity));
            await _appDbContext.SaveChangesAsync();
        }
    }

       

      

        
    }
}
