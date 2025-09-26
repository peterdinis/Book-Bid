using MassTransit;
using SearchService.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddHttpClient<AuctionSvcHttpClient>();
builder.Services.AddMassTransit(x =>
{
    x.UsingRabbitMq((context, ctg) =>
    {
        ctg.ConfigureEndpoints(context);
    });
});

var app = builder.Build();

app.MapControllers();

app.Run();