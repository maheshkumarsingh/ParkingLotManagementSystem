using System.Collections;
using System.Net.NetworkInformation;

namespace ParkingLotManagementSystem.Domain.Models
{
    public class ParkingLot : BaseModel
    {
        public required string Name { get; set; }
        public required string Address { get; set; }
        public ICollection<ParkingFloor> ParkingFloors { get; set; } = [];
        public ICollection<Gate> EntryGates { get; set; } = [];
        public ICollection<Gate> ExitGates { get; set; } = [];
        public DisplayBoard DisplayBoard { get; set; } = new DisplayBoard();
    }
}
