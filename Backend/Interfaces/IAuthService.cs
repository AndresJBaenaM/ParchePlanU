using Microsoft.AspNetCore.Identity;

namespace ApiParchePlanU.Interfaces
{
    public interface IAuthService
    {
<<<<<<< HEAD:Backend/Interfaces/IAuthService.cs
        Task<IdentityResult> Register(string nombreCompleto, string email, string program, string password, string? avatarUrl, string role);
=======
        Task<IdentityResult> Register(string fullName, string email, string programa, string password, string URLAvatar);
>>>>>>> c69b7bc3e4eea9921f372552fd18134c5c3c16ec:Interfaces/IAuthService.cs
        Task<string?> Login(string email, string password);
    }
}
