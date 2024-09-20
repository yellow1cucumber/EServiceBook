using Domain.Core.Cars.CarParts;

namespace Domain.Core.Cars
{
    public class Fluids : Entity, 
                          IChangeable,
                          IIdentifiable
    {
        public string Name { get; set; }
        public string? Description { get; set; }

        public double PricePerUnit { get; set; }
        public IEnumerable<Change> Changes { get; set; } = [];
    }
}
