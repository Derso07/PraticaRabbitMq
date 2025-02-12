using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PraticaRabbitMq.Interface;

namespace PraticaRabbitMq.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly IBusService _busService;
        public TicketController(IBusService busService) 
        {
            _busService = busService;
        }

        [HttpPost]
        public Task<IActionResult> Post() 
        {

        }
    }
}
