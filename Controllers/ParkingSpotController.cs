using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingLotManagementSystem.Domain.Models;

namespace ParkingLotManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingSpotController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAvailabeParkingSpots()
        {
            // Simulate an asynchronous operation
            var parkingSpot = await Task.FromResult(new ParkingSpot());
            return Ok(parkingSpot);
        }
        [HttpPost]
        public async Task<IActionResult> CreateParkingSpot([FromBody] ParkingSpot parkingSpot)
        {
            if (parkingSpot == null)
            {
                return BadRequest("Parking spot cannot be null");
            }
            // Simulate an asynchronous operation
            var createdParkingSpot = await Task.FromResult(parkingSpot);
            return CreatedAtAction(nameof(GetAvailabeParkingSpots), new { id = createdParkingSpot.SpotId }, createdParkingSpot);
        }
    }
}
