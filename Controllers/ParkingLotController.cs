using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ParkingLotManagementSystem.Domain.Models;
using ParkingLotManagementSystem.Dtos;

namespace ParkingLotManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingLotController : ControllerBase
    {
        private readonly IMapper _mapper;

        public ParkingLotController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost(Name = "create")]
        public async Task<IActionResult> CreateParkingLot([FromBody] CreateParkingLotRequestDto request)
        {
            if (request == null && !ModelState.IsValid)
            {
                return BadRequest("Parking lot request cannot be null");
            }
            // Map the DTO to the domain model
            var parkingLot = _mapper.Map<ParkingLot>(request);
            // Simulate an asynchronous operation
            var createdParkingLot = await Task.FromResult(parkingLot);
            return CreatedAtAction(nameof(ParkingLot), new { id = createdParkingLot.Id }, createdParkingLot);
        }
    }
}
