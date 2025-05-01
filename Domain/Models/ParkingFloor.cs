namespace ParkingLotManagementSystem.Domain.Models
{
    public class ParkingFloor : BaseModel
    {
        public int FloorNumber { get; set; }
        public List<ParkingSpot> ParkingSpots { get; set; }
        public DisplayBoard DisplayBoard { get; set; }
        public PaymentCounter PaymentCounter { get; set; }
    }
}