using PraticaRabbitMq.Enum;

namespace PraticaRabbitMq.Model.Input
{
    public class TicketInputModel
    {
        public Guid Id { get; set; }
        public string PassengerName { get; set; }
        public decimal Price { get; set; }
        public int Seat { get; set; }
        public PaymentType TypePayment { get; set; }

    }
}
