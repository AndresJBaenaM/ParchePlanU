using ApiParchePlanU.Interfaces;
using ApiParchePlanU.Models;
using ApiParchePlanU.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiParchePlanU.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class RankingController : ControllerBase
    {
        private readonly IRankingServices _rankingService;

        public RankingController(IRankingServices rankingService)
        {
            _rankingService = rankingService;
        }

        [HttpGet("{parcheId}")]
        public async Task<ActionResult<List<Ranking>>> GetRanking(int parcheId)
        {
            var ranking = await _rankingService.GetRanking(parcheId);
            return Ok(ranking);
        }
    }
}