namespace WebApi.Domain.Models
{
    public class Car : Entity
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public DateTime YearManufacture { get; set; }
    }
}
