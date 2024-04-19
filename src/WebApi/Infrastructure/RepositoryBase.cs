using Microsoft.EntityFrameworkCore;
using WebApi.Context;
using WebApi.Domain.Models;
using WebApi.Interfaces;

namespace WebApi.Infrastructure
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : Entity
    {
        public readonly DbSet<TEntity> _dbSet;
        public readonly DataContext _dataContext;

        public RepositoryBase(DbSet<TEntity> dbSet, DataContext dataContext)
        {
            _dbSet = dbSet;
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var query = _dbSet.AsQueryable();

            return await query.ToListAsync();
        }
    }
}
