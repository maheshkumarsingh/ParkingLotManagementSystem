using ParkingLotManagementSystem.Domain.Models;

namespace ParkingLotManagementSystem.ObserverDesignPattern
{
    public class Implementation
    {
        public void Implement()
        {
            var slotManager = new ParkingSlotManager();
            slotManager.InitializeSlots(10, 15, 5);

            var gateA = new EntryGateDisplay("Gate A");
            var gateB = new EntryGateDisplay("Gate B");
            var mobileApp = new MobileAppDisplay();

            slotManager.RegisterObserver(gateA);
            slotManager.RegisterObserver(gateB);
            slotManager.RegisterObserver(mobileApp);

            // Simulate a two-wheeler entering
            slotManager.UpdateAvailableSlots(VechileType.Small, isOccupied: true);

            // Simulate a bus leaving
            slotManager.UpdateAvailableSlots(VechileType.Large, isOccupied: false);
        }
    }
}
