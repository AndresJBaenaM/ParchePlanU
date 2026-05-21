using Microsoft.AspNetCore.Mvc;
using ApiParchePlanU.Interfaces;
using ApiParchePlanU.Models;
using Microsoft.AspNetCore.Authorization;

namespace ApiParchePlanU.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ParcheController : ControllerBase
    {
        private readonly IParcheService _parcheService;

        public ParcheController(IParcheService parcheService)
        {
            _parcheService = parcheService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Parche>>> GetAll()
        {
            var parches = await _parcheService.GetAll();
            return Ok(parches);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Parche>> GetById(int id)
        {
            var parche = await _parcheService.GetById(id);
            if (parche == null)
                return NotFound("Parche no encontrado");
            return Ok(parche);
        }

        [HttpPost]
        public async Task<ActionResult<Parche>> Create([FromBody] Parche parche, [FromQuery] string creatorId)
        {
            parche.CreatorId = creatorId;
            var nuevoParche = await _parcheService.Create(parche);
            return Ok(nuevoParche);
        }

        [HttpPost("join")]
        public async Task<IActionResult> JoinParche(
            [FromQuery] string userId,
            [FromQuery] string inviteCode)
        {
            await _parcheService.JoinParche(userId, inviteCode);
            return Ok("Usuario unido al parche");
        }

        [HttpGet("{parcheId}/members")]
        public async Task<ActionResult<List<ParcheMember>>> GetMembers(int parcheId)
        {
            var members = await _parcheService.GetMembers(parcheId);
            return Ok(members);
        }
    }
}

//Verificacion de que todo se actualizo...