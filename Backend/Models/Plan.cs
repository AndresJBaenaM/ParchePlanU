using ApiParchePlanU.Models.Enums;

namespace ApiParchePlanU.Models
{
    public class Plan
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
<<<<<<< HEAD:Backend/Models/Plan.cs
        public string? CreatorId {  get; set; }
        public DateTime StartVoting {  get; set; }
=======
        public string CreatorId { get; set; }
        public DateTime StartVoting { get; set; }
>>>>>>> 1cd0d80ca1d36ce6426813e4ebba9c8f24b9e434:Models/Plan.cs
        public DateTime EndVoting { get; set; }
        public PlanState State { get; set; }
        public int ParcheId { get; set; }
        public Parche? parche { get; set; }
<<<<<<< HEAD:Backend/Models/Plan.cs
        public List<PlanOption>? Options {  get; set; }
=======
        public User? Creator { get; set; }
        public List<PlanOption> Options { get; set; }
>>>>>>> 1cd0d80ca1d36ce6426813e4ebba9c8f24b9e434:Models/Plan.cs
        public List<Attendance>? Attendances { get; set; }
        public List<Vote>? Votes { get; set; }
    }
}