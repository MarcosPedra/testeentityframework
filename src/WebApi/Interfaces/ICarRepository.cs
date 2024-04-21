using WebApi.Domain.Models;
using WebApi.Dtos;

namespace WebApi.Interfaces
{
    public interface ICarRepository
    {
        Task<IEnumerable<Car>> GetAllCarAsync();
        Task<CarDto> GetCarsWithPaginationAsync(int skip, int take);
    }
}
