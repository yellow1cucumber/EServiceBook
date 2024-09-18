namespace Domain.Core.Cars
{
    public class Fluids : Entity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public double PricePerUnit { get; set; }
    }
}
