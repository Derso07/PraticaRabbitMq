using Microsoft.AspNetCore.Mvc;
using PraticaRabbitMq.Interface;
using PraticaRabbitMq.Model.Created;
using PraticaRabbitMq.Model.Input;

namespace PraticaRabbitMq.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly IBusService _busService;
        private readonly ITicketService _ticketService;
        public TicketController(IBusService busService, ITicketService ticketService)
        {
            _busService = busService;
            _ticketService = ticketService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(TicketInputModel model)
        {
            var @event = new TicketCreatedModel(model.Id, model.PassengerName, model.Price, model.Seat, model.TypePayment);

            await _busService.Publish(@event);

            return NoContent();
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_ticketService.GetAll());
        }
    }
}
