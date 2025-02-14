using PraticaRabbitMq.Interface;
using PraticaRabbitMq.Model.Input;

namespace PraticaRabbitMq.Repository
{
    public class TicketRepository : ITicketService
    {
        private readonly List<TicketInputModel> _tickets = [];
        public void Add(TicketInputModel inputModel)
        {
            _tickets.Add(inputModel);
        }

        public List<TicketInputModel> GetAll()
        {
            return _tickets;
        }
    }
}
