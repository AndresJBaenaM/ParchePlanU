using Microsoft.AspNetCore.Identity;

namespace ApiParchePlanU.Interfaces
{
    public interface IAuthService
    {
        Task<IdentityResult> Register(string nombreCompleto, string email, string program, string password, string? avatarUrl, string role);
        Task<string?> Login(string email, string password);
    }
}
