using Domain.Core.Car.CarParts;

namespace Domain.Core.Cars.CarUnits
{
    public class CarUnit : Entity, IIdentifiable
    {
        public string Name { get; set; }
        public string? Description { get; set; }

        public IEnumerable<CarPart> Parts { get; set; } = [];
        public IEnumerable<Fluids> Fluids { get; set; } = [];
    }
}
