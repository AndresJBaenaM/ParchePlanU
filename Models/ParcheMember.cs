using ApiParchePlanU.Models.Enums;

namespace ApiParchePlanU.Models
{
    public class ParcheMember
    {
        public int Id { get; set; }
        public string UsuarioId { get; set; }
        public int ParcheId { get; set; }
        public ParcheRole Role { get; set; }
        public User user { get; set; }
        public Parche parche { get; set; }
    }
}
