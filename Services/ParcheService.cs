using ApiParchePlanU.DAO;
using ApiParchePlanU.Interfaces;
using ApiParchePlanU.Models;
using Microsoft.EntityFrameworkCore;
using ApiParchePlanU.Models.Enums;

namespace ApiParchePlanU.Services
{
    public class ParcheService : IParcheService
    {
        public readonly ApplicationDbContext _context; 

        public ParcheService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Parche>> GetAll()
        {
            return await _context.Parches.ToListAsync(); 
        }

        public async Task<Parche> GetById(int id)
        {
            return await _context.Parches.FindAsync(id); 
        }
        public async Task<Parche> Create(Parche parche)
        {
            parche.CoverImageUrl = parche.CoverImageUrl ?? "";
            _context.Parches.Add(parche);
            await _context.SaveChangesAsync();
            return parche;
        }

        public async Task JoinParche(string usuarioId, string inviteCode)
        {
            var parche = await _context.Parches.FirstOrDefaultAsync(p => p.InviteCode == inviteCode);
            var member = new ParcheMember
            {
                UsuarioId = usuarioId,
                ParcheId = parche.Id,
                Role = ParcheRole.Member
            }; 
            _context.ParcheMembers.Add(member);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ParcheMember>> GetMembers(int parcheId)
        {
            return await _context.ParcheMembers
                .Where(m => m.ParcheId == parcheId)
                .Include(m => m.user)
                .ToListAsync();
        }
    }
}
