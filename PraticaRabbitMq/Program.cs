using MassTransit;
using PraticaRabbitMq.Bus;
using PraticaRabbitMq.Interface;
using PraticaRabbitMq.Repository;
using PraticaRabbitMq.Subscribers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IBusService, MassTransitBusService>();
builder.Services.AddScoped<ITicketService, TicketRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMassTransit(x =>
{
    x.AddConsumer<TicketCreatedSubscriber>();

    x.UsingRabbitMq((context, cfg) =>
    {   
        cfg.ConfigureEndpoints(context);
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
