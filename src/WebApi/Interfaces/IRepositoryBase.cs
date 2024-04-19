using WebApi.Domain.Models;

namespace WebApi.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
