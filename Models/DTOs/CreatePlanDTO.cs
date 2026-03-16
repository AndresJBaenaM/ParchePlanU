using System.ComponentModel.DataAnnotations;

namespace ApiParchePlanU.Models.DTOs
{
    public class CreatePlanDTO
    {
        [Required]
        public string id { get; set; } = null!;
        [Required]
        public string title { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
