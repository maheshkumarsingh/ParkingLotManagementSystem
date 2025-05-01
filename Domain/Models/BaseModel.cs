namespace ParkingLotManagementSystem.Domain.Models
{
    public abstract class BaseModel
    {
        // Audit fields -> Check Database things when things are created and updated.
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
