using ApiParchePlanU.DAO;
using ApiParchePlanU.Interfaces;
using ApiParchePlanU.Models;
using ApiParchePlanU.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace ApiParchePlanU.Services
{
    public class RankingService : IRankingServices
    {
        private readonly ApplicationDbContext _context;
        public RankingService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Ranking>> GetRanking(int parcheId)
        {
            var members = await _context.ParcheMembers
                .Where(m => m.ParcheId == parcheId)
                .Include(m => m.user)
                .ToListAsync();

            var rankingList = new List<Ranking>();

            foreach (var member in members)
            {
                var organizerScore = await _context.Plans
                    .Where(p => p.CreatorId == member.UsuarioId && p.ParcheId == parcheId)
                    .CountAsync();

                var ghostScore = await _context.Attendances
                    .Where(a => a.UserId == member.UsuarioId && a.Status == AttendanceStatus.Yes)
                    .CountAsync();

                rankingList.Add(new Ranking
                {
                    UserId = member.UsuarioId,
                    UserName = member.user?.NombreCompleto ?? member.UsuarioId,
                    OrganizerScore = organizerScore,
                    GhosScore = ghostScore
                });
            }
            return rankingList;
        }
    }
}