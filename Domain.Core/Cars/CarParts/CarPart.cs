namespace Domain.Core.Cars.CarParts
{
    public class CarPart : Entity,
                           IMaintainable, 
                           IChangeable,
                           IIdentifiable
    {
        public string Name { get; set; }
        public string? Description { get; set; }

        public IEnumerable<Maintenance> Maintenances { get; set; } = [];
        public IEnumerable<Change> Changes { get; set; } = [];
    }
}
