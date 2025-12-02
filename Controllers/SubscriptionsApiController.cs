using Microsoft.AspNetCore.Mvc;

namespace VermutClub.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubscriptionsApiController : ControllerBase
    {
        // 👉 Necesario para que el CORS funcione
        [HttpOptions]
        public IActionResult Options()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] SubscriptionRequest request)
        {
            Console.WriteLine("=== Nueva suscripción recibida ===");
            Console.WriteLine($"Nombre: {request.Nombre}");
            Console.WriteLine($"Email: {request.Email}");
            Console.WriteLine($"Phone: {request.Phone}");
            Console.WriteLine($"Plan: {request.Plan}");
            Console.WriteLine("=================================");

            return Ok(new { message = "Suscripción recibida correctamente" });
        }
    }

    public class SubscriptionRequest
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Plan { get; set; }
    }
}
