namespace ApiParchePlanU.Models
{
    public class Vote
    {
<<<<<<< HEAD:Backend/Models/Vote.cs
        public string UserId { get; set; }
        public int PlanOptionId { get; set; }
        public int PlanId { get; set; }
        public User user {  get; set; }
        public Plan plan {  get; set; }
=======
        public int Id { get; set; }

        public string Usuario_Id { get; set; }

        public int PlanOptionId { get; set; }

        public int Plan_Id { get; set; }

        public User user { get; set; }

>>>>>>> c69b7bc3e4eea9921f372552fd18134c5c3c16ec:Models/Vote.cs
        public PlanOption PlanOption { get; set; }
    }
}