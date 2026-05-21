using System.ComponentModel.DataAnnotations;

namespace ApiParchePlanU.Models.DTOs
{
    public class PlanOption
    {
        [Required]
        public string PlanId { get; set; }
        [Required]
        public string Place { get; set; } = null!;
        [Required]
        public DateTime time {  get; set; }
    }
}
