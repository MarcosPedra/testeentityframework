using WebApi.Domain.Models;
using WebApi.Interfaces;

namespace WebApi.Infrastructure
{
    public class CarRepository : ICarRepository
    {
        private readonly IRepositoryBase<Car> _repositoryBase;

        public CarRepository(IRepositoryBase<Car> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public async Task<IEnumerable<Car>> GetAllCarAsync()
        {
            return await _repositoryBase.GetAllAsync();
        }
    }
}
