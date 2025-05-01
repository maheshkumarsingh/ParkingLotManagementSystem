namespace ParkingLotManagementSystem.Domain.Models
{
    public abstract class Gate : BaseModel
    {
        public string Location { get; set; } = string.Empty;
        public Operator Operator { get; set; }
    }
}