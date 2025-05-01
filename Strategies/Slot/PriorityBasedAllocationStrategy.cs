using ParkingLotManagementSystem.Domain.Models;

namespace ParkingLotManagementSystem.Strategies.Slot
{
    public class PriorityBasedAllocationStrategy : ISlotAllocationStrategy
    {
        ParkingSpot? ISlotAllocationStrategy.FindSpot(Vechile vechile, List<ParkingSpot> availableSpots)
        {
            throw new NotImplementedException();
        }
    }
}
