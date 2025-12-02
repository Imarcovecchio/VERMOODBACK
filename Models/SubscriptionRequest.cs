public class SubscriptionsRequest
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Plan { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
