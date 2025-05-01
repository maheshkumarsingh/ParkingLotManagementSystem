using ParkingLotManagementSystem.Domain.Models;

namespace ParkingLotManagementSystem.Repositories
{
    public interface ITicketRepository
    {
        Ticket CreateTicket(Vechile vechile, ParkingSpot parkingSpot);
        Ticket GetTicketById(int ticketId);
        void UpdateTicket(Ticket ticket);
        void DeleteTicket(int ticketId);
        List<Ticket> GetAllTickets();
        List<Ticket> GetTicketsByVechileType(string vechileType);
        List<Ticket> GetTicketsByParkingSpot(ParkingSpot parkingSpot);
    }
}
