using Domain.Core.Cars.CarUnits;

namespace Domain.Core.Cars
{
    public class Car : Entity
    {
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Mileage { get; set; }
        public string RegistrationNumber { get; set; }

        public IEnumerable<CarUnit> CarUnits { get; set; } = [];
    }
}
