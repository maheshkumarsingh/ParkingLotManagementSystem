using ParkingLotManagementSystem.Domain.Models;

namespace ParkingLotManagementSystem.Repositories
{
    public interface IParkingSpotRepository
    {
        ParkingSpot CreateParkingSpot(ParkingSpot parkingSpot);
        ParkingSpot GetParkingSpotById(int id);
        void UpdateParkingSpot(ParkingSpot parkingSpot);
        void DeleteParkingSpot(int id);
        List<ParkingSpot> GetAllParkingSpots();
        List<ParkingSpot> GetAvailableParkingSpots();
        List<ParkingSpot> GetOccupiedParkingSpots();
        List<ParkingSpot> GetParkingSpotsByType(string type);
        bool UpdateParkingSpotStatus(int id, ParkingSpotStatus status);
    }
}
