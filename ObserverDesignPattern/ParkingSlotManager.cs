using ParkingLotManagementSystem.Domain.Models;
using System.Runtime.CompilerServices;

namespace ParkingLotManagementSystem.ObserverDesignPattern
{
    public class ParkingSlotManager
    {
        private readonly List<ISlotAvailabilityObserver> _observers = [];
        private int _availableSmallWheelerSlots;
        private int _availableMediumWheelerSlots;
        private int _availableLargeWheelerSlots;


        public void RegisterObserver(ISlotAvailabilityObserver observer)
        {
            _observers.Add(observer);
        }        
        public void UnRegisterObserver(ISlotAvailabilityObserver observer)
        {
            _observers.Remove(observer);
        }
        private void NotifyObservers()
        {
            foreach(var observer in _observers)
            {
                observer.Update(_availableSmallWheelerSlots, _availableMediumWheelerSlots, _availableLargeWheelerSlots);
            }
        }

        public void UpdateAvailableSlots(VechileType vechileType, bool isOccupied)
        {
            switch(vechileType)
            {
                case VechileType.Small:
                    _availableSmallWheelerSlots += isOccupied ? -1 : 1;
                    break;
                case VechileType.Medium:
                    _availableMediumWheelerSlots += isOccupied ? -1 : 1;
                    break;
                case VechileType.Large:
                    _availableLargeWheelerSlots += isOccupied ? -1 : 1;
                    break;
            }
            NotifyObservers();
        }
        public void InitializeSlots(int small, int medium, int large)
        {
            _availableSmallWheelerSlots = small;
            _availableMediumWheelerSlots = medium;
            _availableLargeWheelerSlots = large;
            NotifyObservers();
        }
    }
}
