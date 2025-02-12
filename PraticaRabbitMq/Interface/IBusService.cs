namespace PraticaRabbitMq.Interface
{
    public interface IBusService
    {
        Task Publish<T>(T message);
    }
}
