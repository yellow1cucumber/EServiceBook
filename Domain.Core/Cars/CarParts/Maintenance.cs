namespace Domain.Core.Cars.CarParts
{
    public class Maintenance : Entity
    {
        public DateTime Date { get; set; }
        public string Description { get; set; } = string.Empty;
        public double Mileage { get; set; }
        public double? MotorHours { get; set; } = null;

        public double Price { get; set; }
    }
}
