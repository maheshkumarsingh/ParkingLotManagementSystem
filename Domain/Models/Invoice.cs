namespace ParkingLotManagementSystem.Domain.Models
{
    public class Invoice : BaseModel
    {
        public string InvoiceNumber { get; set; } = string.Empty;
        public DateTime ExitTime { get; set; }
        public string TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public double Amount { get; set; }
        public string PaymentId { get; set; }
        public Payment Payment { get; set; }
    }
}
