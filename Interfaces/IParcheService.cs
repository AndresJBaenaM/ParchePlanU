using ApiParchePlanU.Models;

namespace ApiParchePlanU.Interfaces
{
    public interface IParcheService
    {
        Task<List<Parche>> GetAll(); 
        Task<Parche> GetById(int id);
        Task<Parche> Create(Parche parche);
        Task JoinParche(string UsuarioId, string inviteCode);
        Task<List<ParcheMember>> GetMembers(int parcheId); 
    }
}
