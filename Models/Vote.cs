namespace ApiParchePlanU.Models
{
    public class Vote
    {
        public string UserId { get; set; }
        public int PlanOptionId { get; set; }
        public int PlanId { get; set; }
        public User user {  get; set; }
        public Plan plan {  get; set; }
        public PlanOption PlanOption { get; set; }
    }
}
