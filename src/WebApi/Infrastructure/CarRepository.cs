using Microsoft.EntityFrameworkCore;
using WebApi.Context;
using WebApi.Domain.Models;
using WebApi.Dtos;
using WebApi.Interfaces;

namespace WebApi.Infrastructure
{
    public class CarRepository : ICarRepository
    {
        
        public readonly DataContext _dataContext;

        public CarRepository(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public async Task<IEnumerable<Car>> GetAllCarAsync()
        {
            return await _dataContext.Cars
                           .AsNoTracking()
                           .ToListAsync();
        }

        public async Task<CarDto> GetCarsWithPaginationAsync(int skip, int take)
        {
            var total = await _dataContext.Cars.CountAsync();
            var data = await _dataContext.Cars
                             .AsNoTracking()
                             .Skip(skip)
                             .Take(take)
                             .ToListAsync();

            return new CarDto(total, data);
        }
    }
}
