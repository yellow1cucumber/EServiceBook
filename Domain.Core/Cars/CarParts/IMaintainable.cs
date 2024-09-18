namespace Domain.Core.Cars.CarParts
{
    public interface IMaintainable
    {
        public IEnumerable<Maintenance> Maintenances { get; set; }
    }
}
