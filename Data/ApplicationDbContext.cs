using Microsoft.EntityFrameworkCore;
using VermutClub.Models;

namespace VermutClub.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<SubscriptionRequest> SubscriptionRequests { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // --- Relaciones Actualizadas ---

            // User - Address (1:M)
            // Un usuario tiene múltiples direcciones (Addresses), 
            // una dirección pertenece a un solo usuario.
            modelBuilder.Entity<User>()
                .HasMany(u => u.Addresses)       // El usuario tiene MUCHAS direcciones
                .WithOne(a => a.User)            // La dirección pertenece a UN usuario
                .HasForeignKey(a => a.UserId);   // La FK está en la tabla Addresses

            modelBuilder.Entity<User>()
                .HasOne(u => u.Subscription)
                .WithMany(s => s.Users) // 👈 vinculás explícitamente con la colección
                .HasForeignKey(u => u.SubscriptionId)
                .OnDelete(DeleteBehavior.Restrict);


            // Order - Address (M:1)
            // Un pedido se envía a UNA dirección específica (ShippingAddress).
            // Una dirección puede ser usada para MUCHOS pedidos (OrdersUsingThisAddress).
            modelBuilder.Entity<Order>()
                .HasOne(o => o.ShippingAddress)
                .WithMany(a => a.OrdersUsingThisAddress)
                .HasForeignKey(o => o.AddressId)
                .OnDelete(DeleteBehavior.Restrict); // Evita borrar una dirección si tiene pedidos asociados.

            // Order - Payment (1:1)
            // Un pedido tiene UN pago, un pago pertenece a UN pedido. (Esta relación se mantiene igual)
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Payment)
                .WithOne(p => p.Order)
                .HasForeignKey<Payment>(p => p.OrderId);
        }
    }   
}
