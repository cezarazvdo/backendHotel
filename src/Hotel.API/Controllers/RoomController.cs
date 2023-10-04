using Hotel.Domain.Models;
using Hotel.Infra.Context;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.API.Controllers
{
    [Route("api/agendamentos/rooms")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private AppAgendamentoContext _context;

        public RoomController(AppAgendamentoContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddRoom(Room room)
        {
            _context.Rooms.Add(room);
            var result = await _context.SaveChangesAsync();

            return result > 0 ? Ok(result) : BadRequest(result);
        }
    }
}
