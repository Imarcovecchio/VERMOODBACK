namespace VermutClub.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public string Status { get; set; }
        public decimal Total { get; set; }

        // ¡CAMBIO CLAVE! Referencia a la dirección de envío para este pedido.
        public int AddressId { get; set; }
        public virtual Address ShippingAddress { get; set; } // Propiedad de navegación para EF Core


        public virtual User? User { get; set; }
        public virtual Payment? Payment { get; set; }
    }
}
