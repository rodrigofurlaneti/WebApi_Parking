namespace Parking.Domain.Entities
{
    public class VehicleEntity : BaseEntity
    {
        public TypeEntity? Type { get; set; }
        public ColorEntity? Color { get; set; }
        public BrandEntity? Brand { get; set; }
        public ModelEntity? Model { get; set; }
        public string? Plate { get; set; }
        public string? EntryDate { get; set; }
        public string? EntryTime { get; set; }
        public string? DepartureDate { get; set; }
        public string? DepartureTime { get; set; }
        public bool Parked { get; set; }
    }
}
