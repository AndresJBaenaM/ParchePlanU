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
            // Verificar si el usuario ya votó
            var existingVote = await _context.Votes
                .FirstOrDefaultAsync(v => v.UserId == userId);

            if (existingVote != null)
            {
                throw new Exception("El usuario ya votó");
            }

            var vote = new Vote
            {
                UserId = userId,
                PlanOptionId = optionId
            };
            _context.Votes.Add(vote);
            await _context.SaveChangesAsync();
        }
        public async Task ChangeVote(string userId, int optionId)
        {
            var vote = await _context.Votes.FirstOrDefaultAsync(vote => vote.UserId == userId);
            if (vote == null)
                return; 
            
            vote.PlanOptionId = optionId;
            await _context.SaveChangesAsync();
        }

        public async Task<List<Vote>> GetResults(int planId)
        {
            return await _context.Votes.Include(v => v.PlanOption).Where(v => v.PlanOption.PlanId == planId).ToListAsync(); 
        }
    }
}
