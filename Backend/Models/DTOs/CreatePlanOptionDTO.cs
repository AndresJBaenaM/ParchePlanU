using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ApiParchePlanU.Models.DTOs
{
    public class CreatePlanOptionDTO
    {
        [Required]
        public string Place { get; set; } = null!; 
        [Required]
        public DateTime Time {  get; set; }
    }
}
