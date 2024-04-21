using WebApi.Domain.Models;

namespace WebApi.Dtos
{
    public record CarDto(
        int Total, 
        List<Car> Cars);
}
