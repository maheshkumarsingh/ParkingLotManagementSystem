using ParkingLotManagementSystem.Domain.Models;
using ParkingLotManagementSystem.Repositories;
using ParkingLotManagementSystem.Strategies.Slot;

namespace ParkingLotManagementSystem.Services
{
    public class TicketService
    {
        private readonly SlotAllocationStrategyFactory _strategyFactory;
        private readonly ITicketRepository _ticketRepository;
        private readonly IParkingSpotRepository _parkingSpotRepository;

        public TicketService(SlotAllocationStrategyFactory strategyFactory, ITicketRepository ticketRepository, IParkingSpotRepository parkingSpotRepository)
        {
            _strategyFactory = strategyFactory;
            _ticketRepository = ticketRepository;
            _parkingSpotRepository = parkingSpotRepository;
        }

        public Ticket? CreateTicket(Vechile vechile, SlotAllocationType slotAllocationType)
        {
            var strategy = _strategyFactory.GetAllocationStrategy(slotAllocationType);
            var availableSpots = _parkingSpotRepository.GetAvailableParkingSpots();
            var selectedSpot = strategy.FindSpot(vechile, availableSpots);
            if (selectedSpot == null)
            {
                return null; // No available spot found
            }
            _parkingSpotRepository.UpdateParkingSpotStatus(selectedSpot.SpotId, ParkingSpotStatus.Occupied);

            var ticket = new Ticket
            {
                TicketId = Guid.NewGuid().ToString(),
                VechileId = vechile.Id.ToString(),
                SlotNumber = selectedSpot.Id,
                EntryTime = DateTime.Now,
            };
            return ticket;
        }
    }
}
