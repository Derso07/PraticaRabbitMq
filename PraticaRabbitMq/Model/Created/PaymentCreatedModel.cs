using PraticaRabbitMq.Enum;

namespace PraticaRabbitMq.Model.Created
{
    public class PaymentCreatedModel
    {
        public PaymentCreatedModel(Guid id, DateTime datePayment, PaymentType typePayment)
        {
            Id = id;
            DatePayment = datePayment;
            TypePayment = typePayment;
        }

        public Guid Id { get; set; }
        public DateTime DatePayment { get; set; }
        public PaymentType TypePayment { get; set; }
    }
}
