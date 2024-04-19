using WebApi.Domain.Models;

namespace WebApi.Interfaces
{
    public interface ICarRepository : IRepositoryBase<Car>
    {
        Task<IEnumerable<Car>> GetAllCarAsync();
    }
}
