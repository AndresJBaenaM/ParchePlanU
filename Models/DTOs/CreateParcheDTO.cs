using System.ComponentModel.DataAnnotations;

namespace ApiParchePlanU.Models.DTOs
{
    public class CreateParcheDTO
    {
        [Required]
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!; 
        public string ConverImageUrl { get; set; } = null!;
    }
}
