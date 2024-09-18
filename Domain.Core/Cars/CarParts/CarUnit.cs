using Domain.Core.Car.CarParts;

namespace Domain.Core.Cars.CarUnits
{
    public class CarUnit : Entity
    {
        public string Name { get; set; } = string.Empty;

        public IEnumerable<CarPart> Parts { get; set; } = [];
        public IEnumerable<Fluids> Fluids { get; set; } = [];
    }
}
