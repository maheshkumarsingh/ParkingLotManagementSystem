using ParkingLotManagementSystem.Domain.Models;

namespace ParkingLotManagementSystem.Strategies.Slot
{
    public interface ISlotAllocationStrategy
    {
        ParkingSpot? FindSpot(Vechile vechile, List<ParkingSpot> availableSpots);
    }
}
