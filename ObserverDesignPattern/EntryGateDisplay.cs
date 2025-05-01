namespace ParkingLotManagementSystem.ObserverDesignPattern
{
    public class EntryGateDisplay:ISlotAvailabilityObserver
    {
        private readonly string _gateName;

        public EntryGateDisplay(string gateName)
        {
            _gateName = gateName;
        }

        public void Update(int availableSmallWheelerSlots, int availableMediumWheelerSlots, int availableLargeWheelerSlots)
        {
            Console.WriteLine($"[{_gateName}] Slots Available - 2W: {availableSmallWheelerSlots}, 4W: {availableMediumWheelerSlots}, Bus: {availableLargeWheelerSlots}");
        }
    }
}
