using PraticaRabbitMq.Model.Input;

namespace PraticaRabbitMq.Interface
{
    public interface ITicketService
    {
        void Add(TicketInputModel inputModel);
        List<TicketInputModel> GetAll();
    }
}
