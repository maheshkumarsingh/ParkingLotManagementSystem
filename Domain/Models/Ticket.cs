namespace ParkingLotManagementSystem.Domain.Models
{
    public class Ticket : BaseModel
    {
        public string TicketId { get; set; }
        public string VechileId { get; set; }
        public VechileType VechileType { get; set; }
        public int FloorNumber { get; set; }
        public int SlotNumber { get; set; }
        public DateTime EntryTime { get; set; }
        public DateOnly ExitTime { get; set; }
        public TicketStatus TicketStatus { get; set; }
    }
}
