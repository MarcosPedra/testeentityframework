namespace WebApi.Domain.Models
{
    public class Car : Entity
    {
        public Car(Guid id, string brand, string model, string color, DateTime yearManufacture) : base(id)
        {
            Brand = brand;
            Model = model;
            Color = color;
            YearManufacture = yearManufacture;
        }

        public string Brand { get; private set; }
        public string Model { get; private set; }
        public string Color { get; private set; }
        public DateTime YearManufacture { get; private set; }
    }
}
