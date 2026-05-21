namespace ApiParchePlanU.Models
{
    public class PlanOption
    {
        public int Id { get; set; }
        public string Lugar { get; set; }
        public DateTime Time { get; set; }
        public int PlanId { get; set; }
<<<<<<< HEAD:Backend/Models/PlanOption.cs
        public Plan plan { get; set; }
=======
        public Plan? plan { get; set; }
        public ICollection<Vote> Votes { get; set; } = new List<Vote>();
        public int VoteCount => Votes?.Count ?? 0;
>>>>>>> 1cd0d80ca1d36ce6426813e4ebba9c8f24b9e434:Models/PlanOption.cs
    }
}