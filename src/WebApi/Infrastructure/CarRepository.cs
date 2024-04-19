using WebApi.Domain.Models;
using WebApi.Interfaces;

namespace WebApi.Infrastructure
{
    public class CarRepository : ICarRepository
    {
        public Task<IEnumerable<Car>> GetAllCarAsync()
        {
            throw new NotImplementedException();
        }
    }
}
