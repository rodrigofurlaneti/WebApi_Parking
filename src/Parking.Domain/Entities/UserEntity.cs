namespace Parking.Domain.Entities
{
    public class UserEntity
    {
        public int IdUser { get; set; }
        public string? Name { get; set; }
        public ProfileEntity? Profile { get; set; }
        public bool Status { get; set; }
        public DateTime Insert { get; set; }
        public DateTime Update { get; set; }
    }
}
