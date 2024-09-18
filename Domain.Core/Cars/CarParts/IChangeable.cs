namespace Domain.Core.Cars.CarParts
{
    public interface IChangeable
    {
        public IEnumerable<Change> Changes { get; set; }
    }
}
