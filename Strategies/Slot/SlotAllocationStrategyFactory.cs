namespace ParkingLotManagementSystem.Strategies.Slot
{
    public class SlotAllocationStrategyFactory
    {
        public ISlotAllocationStrategy GetAllocationStrategy(SlotAllocationType type)
        {
            return type switch
            {
                SlotAllocationType.Nearest => new NearestSlotAllocationStrategy(),
                SlotAllocationType.Random => new RandomSlotAllocationStrategy(),
                SlotAllocationType.PriorityBased => new PriorityBasedAllocationStrategy(),
                _ => throw new ArgumentException("Invalid allocation strategy type")
            };
        }
    }
}
