using Domain.Core.Car.CarParts;

namespace Domain.Core.Cars.CarUnits
{
    public class CarUnit : Entity
    {
        public string Name { get; set; }

        public IEnumerable<CarPart> Parts { get; set; } = [];
    }
}
