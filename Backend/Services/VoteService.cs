using ApiParchePlanU.DAO;
using ApiParchePlanU.Interfaces;
using ApiParchePlanU.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiParchePlanU.Services
{
    public class VoteService : IVoteService
    {
        private readonly ApplicationDbContext _context;
        public VoteService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Vote(string userId, int optionId)
        {
            var option = await _context.PlanOptions.FindAsync(optionId);
            if (option == null) throw new Exception("Opción no encontrada");

            var existingVote = await _context.Votes
                .FirstOrDefaultAsync(v => v.UserId == userId && v.PlanId == option.PlanId);

            if (existingVote != null)
            {
                throw new Exception("El usuario ya votó en este plan");
            }

            var vote = new Vote
            {
                UserId = userId,
                PlanOptionId = optionId,
                PlanId = option.PlanId
            };
            _context.Votes.Add(vote);
            await _context.SaveChangesAsync();
        }

        public async Task ChangeVote(string userId, int optionId)
        {
            var option = await _context.PlanOptions.FindAsync(optionId);
            if (option == null) return;

            var vote = await _context.Votes
                .FirstOrDefaultAsync(v => v.UserId == userId && v.PlanId == option.PlanId);
            if (vote == null) return;

            vote.PlanOptionId = optionId;
            await _context.SaveChangesAsync();
        }

        public async Task<List<Vote>> GetResults(int planId)
        {
<<<<<<< HEAD:Backend/Services/VoteService.cs
            return await _context.Votes.Include(v => v.PlanOption).Where(v => v.PlanOption.PlanId == planId).ToListAsync(); 
=======
            return await _context.Votes
                .Include(v => v.PlanOption)
                .Where(v => v.PlanOption.PlanId == planId)
                .ToListAsync();
>>>>>>> 1cd0d80ca1d36ce6426813e4ebba9c8f24b9e434:Services/VoteService.cs
        }
    }
}