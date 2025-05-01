namespace ParkingLotManagementSystem.ObserverDesignPattern
{
    public class MobileAppDisplay : ISlotAvailabilityObserver
    {

        public void Update(int availableSmallWheelerSlots, int availableMediumWheelerSlots, int availableLargeWheelerSlots)
        {
            Console.WriteLine($"[Mobile App] Updated Slot Info - 2W: {availableSmallWheelerSlots}, 4W: {availableMediumWheelerSlots}, Bus: {availableLargeWheelerSlots}");
        }
    }
}
