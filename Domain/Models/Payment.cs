namespace ParkingLotManagementSystem.Domain.Models
{
    public class Payment : BaseModel
    {
        public string TicketId { get; set; }
        public int Amount { get; set; }
        public PaymentType PaymentType { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
    }
}