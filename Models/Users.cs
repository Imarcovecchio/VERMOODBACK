namespace VermutClub.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Dni { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } 
        public bool Active { get; set; }

        // Relaciones
        public int? SubscriptionId { get; set; }
        
        public virtual Subscription? Subscription { get; set; }


        public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
