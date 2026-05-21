using System.ComponentModel.DataAnnotations;

namespace ApiParchePlanU.Models.DTOs
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "El email es obligatoria")]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [MinLength(8)]
        public string password { get; set; } = null!;

        [Required]
        public string fullName { get; set; } = null!;

        [Required]
        public string Program {  get; set; } = null!;
<<<<<<< HEAD:Backend/Models/DTOs/RegisterDTO.cs
        public string? AvatarUrl { get; set; }
=======

        public string? AvatarUrl { get; set; } = null!;
>>>>>>> 1cd0d80ca1d36ce6426813e4ebba9c8f24b9e434:Models/DTOs/RegisterDTO.cs

    }
}
