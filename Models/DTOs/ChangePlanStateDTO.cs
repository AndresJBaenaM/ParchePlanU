using System.ComponentModel.DataAnnotations;

namespace ApiParchePlanU.Models.DTOs
{
    public class ChangePlanStateDTO
    {
        [Required]
        public string planId { get; set; }
        [Required]
        public string State {  get; set; }
    }
}
