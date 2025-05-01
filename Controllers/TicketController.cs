using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingLotManagementSystem.Domain.Models;

namespace ParkingLotManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        [HttpPost(Name = "create")]
        [Route("createticket")]
        public async Task<IActionResult> CreateTicket([FromBody] Ticket ticket)
        {
            //Vechile.
            //EntryTime = DateTime.Now;
        }
    }
}
