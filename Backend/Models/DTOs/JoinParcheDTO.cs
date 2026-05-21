using System.ComponentModel.DataAnnotations;

namespace ApiParchePlanU.Models.DTOs
{
    public class JoinParcheDTO
    {
        [Required]
        public string InviteCode { get; set; } = null!; 
    }
}
