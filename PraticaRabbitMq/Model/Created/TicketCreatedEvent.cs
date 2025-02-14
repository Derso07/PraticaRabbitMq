using PraticaRabbitMq.Enum;

namespace PraticaRabbitMq.Model.Created
{
    public class TicketCreatedModel
    {
        public TicketCreatedModel(Guid id, string passengerName, decimal price, int seat, PaymentType typePayment)
        {
            Id = id;
            PassengerName = passengerName;
            Price = price;
            Seat = seat;
            TypePayment = typePayment;
        }

        public Guid Id { get; set; }
        public string PassengerName { get; set; }
        public decimal Price { get; set; }
        public int Seat { get; set; }
        public PaymentType TypePayment { get; set; }


    }
}