using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Domain.Models;
using WebApi.Interfaces;

namespace WebApi.Controllers.v1
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Car>>> GetAllCar()
        {
            var cars = await _carRepository.GetAllCarAsync();

            return Ok(cars);
        }

    }
}
