using System.ComponentModel.DataAnnotations;

namespace ApiParchePlanU.Models.DTOs
{
    public class CreatePlanDTO
    {
        [Required]
        public int ParcheId { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string Description   { get; set; }
        [Required] 
        public DateTime StartVoting { get; set; }
        [Required]
        public DateTime EndVoting { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "El plan debe tener minimo 3 opciones")]
        public List<CreatePlanOptionDTO> Options { get; set; } = new(); 
    }
}
