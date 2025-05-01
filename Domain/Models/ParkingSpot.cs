namespace ParkingLotManagementSystem.Domain.Models
{
    public class ParkingSpot : BaseModel
    {
        public int SpotId { get; set; }
        public int FloorId { get; set; }
        public VechileType VechileType { get; set; }
        public ParkingSpotStatus SpotStatus { get; set; }
    }
}