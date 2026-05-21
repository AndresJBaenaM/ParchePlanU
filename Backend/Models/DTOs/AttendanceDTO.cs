using System.ComponentModel.DataAnnotations;

namespace ApiParchePlanU.Models.DTOs
{
    public class AttendanceDTO
    {
        [Required]
        public string PlanId { get; set; }
        [Required]
        public string status { get; set; }
    }
}
