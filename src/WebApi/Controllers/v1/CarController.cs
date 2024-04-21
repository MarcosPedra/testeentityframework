using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Domain.Models;
using WebApi.Dtos;
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

            if(cars == null)
                return NotFound();

            return Ok(cars);
        }

        [HttpGet("carros")]
        public async Task<ActionResult<IEnumerable<CarDto>>> GetCarWithPagination([FromQuery] int skip = 0, [FromQuery] int take = 25)
        {
            if (take > 1000)
            {
                var problemDetails = new ProblemDetails
                {
                    Title = "Número de registros solicitado",
                    Status = 400,
                    Detail = "O número de registros solicitado é superior a 1000 registros"
                };

                return BadRequest(problemDetails);
            }

            var cars = await _carRepository.GetCarsWithPaginationAsync(skip, take);

            return Ok(cars);
        }

    }
}
