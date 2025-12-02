namespace VermutClub.Models
{
    public class Address
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Street { get; set; } 
        public string City { get; set; } 
        public string Province { get; set; } 
        public string PostalCode { get; set; }

        public virtual User? User { get; set; }

        // Nuevo: Campo para identificar fácilmente si es la dirección principal o una de regalo
        public bool IsShippingAddress { get; set; } = true; 
        public virtual ICollection<Order> OrdersUsingThisAddress { get; set; } = new List<Order>();
    }
}
