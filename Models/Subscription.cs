namespace VermutClub.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int DurationMonths { get; set; }
        public bool Active { get; set; } = true;

        public virtual ICollection<User>? Users  { get; set; }
    }
}
