using ApiParchePlanU.Models;

namespace ApiParchePlanU.Interfaces
{
    public interface IVoteService
    {
        Task Vote(string userId, int optionId);
        Task ChangeVote(string userId, int optionId);
        Task<List<Vote>> GetResults(int PlanId); 
    }
}
