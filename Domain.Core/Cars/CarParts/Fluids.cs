using Domain.Core.Cars.CarParts;

namespace Domain.Core.Cars
{
    public class Fluids : Entity, 
                          IChangeable
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public double PricePerUnit { get; set; }
        public IEnumerable<Change> Changes { get; set; } = [];
    }
}
