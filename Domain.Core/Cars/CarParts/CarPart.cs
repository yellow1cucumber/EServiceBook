using Domain.Core.Cars.CarParts;

namespace Domain.Core.Car.CarParts
{
    public class CarPart : Entity,
                           IMaintainable, 
                           IChangeable
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public IEnumerable<Maintenance> Maintenances { get; set; } = [];
        public IEnumerable<Change> Changes { get; set; } = [];
    }
}
