using System.ComponentModel.DataAnnotations;

namespace ApiParchePlanU.Models.DTOs
{
    public class VoteDTO
    {
        [Required]
        public string planOptionId { get; set; }
    }
}
