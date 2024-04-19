using WebApi.Domain.Models;

namespace WebApi.Interfaces
{
    public interface ICarRepository
    {
        Task<IEnumerable<Car>> GetAllCarAsync();
    }
}
