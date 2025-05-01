namespace ParkingLotManagementSystem.ObserverDesignPattern
{
    public interface ISlotAvailabilityObserver
    {
        void Update(int availableSmallWheelerSlots, int availableMediumWheelerSlots, int availableLargeWheelerSlots);
    }
}
