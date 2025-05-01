using ParkingLotManagementSystem.Domain.Models;

namespace ParkingLotManagementSystem.Strategies.Slot
{
    public class NearestSlotAllocationStrategy : ISlotAllocationStrategy
    {
        public ParkingSpot? FindSpot(Vechile vechile, List<ParkingSpot> availableSpots)
        {
            return availableSpots
                .Where(availableSpots => availableSpots.SpotStatus.ToString() == Enum.GetName(ParkingSpotStatus.Available))
                .OrderBy(availableSpots => availableSpots.SpotId)
                .FirstOrDefault(availableSpots => availableSpots.VechileType == vechile.VechileType);
        }
    }
}
