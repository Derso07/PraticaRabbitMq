using MassTransit;
using PraticaRabbitMq.Interface;
using PraticaRabbitMq.Model.Created;
using PraticaRabbitMq.Model.Input;

namespace PraticaRabbitMq.Subscribers
{
    public class TicketCreatedSubscriber : IConsumer<TicketCreatedModel>
    {
        private readonly IBusService _busService;
        private readonly ITicketService _ticketService;

        public TicketCreatedSubscriber(IBusService busService, ITicketService ticketService)
        {
            _busService = busService;
            _ticketService = ticketService;
        }

        public async Task Consume(ConsumeContext<TicketCreatedModel> context)
        {
            try {
                var @event = context.Message;

                var inputModel = new TicketInputModel
                {
                    Id = @event.Id,
                    PassengerName = @event.PassengerName,
                    Price = @event.Price,
                    Seat = @event.Seat,
                    TypePayment = @event.TypePayment
                };

                _ticketService.Add(inputModel);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
            
        }
    }
}
