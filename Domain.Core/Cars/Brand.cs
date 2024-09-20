namespace Domain.Core.Car
{
    public class Brand : Entity, IIdentifiable
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Logo { get; set; } = string.Empty;
    }
}
