using Domain.Core.Car.CarParts;

namespace Domain.Core.Cars.CarParts
{
    public class Change : Entity
    {
        public DateTime Date { get; set; }
        public string Description { get; set; } = string.Empty;
        public double Mileage { get; set; }
        public double? MotorHours { get; set; } = null;

        public CarPart Old { get; set; }
        public CarPart New { get; set; }
    }
}
