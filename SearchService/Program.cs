using MassTransit;
using SearchService.Consumers;
using SearchService.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddHttpClient<AuctionSvcHttpClient>();
builder.Services.AddMassTransit(x =>
{
    x.AddConsumersFromNamespaceContaining<AuctionCreatedConsumer>();
    x.SetEndpointNameFormatter(new KebabCaseEndpointNameFormatter("search", false));
    x.UsingRabbitMq((context, ctg) =>
    {
        ctg.ConfigureEndpoints(context);
    });
});

var app = builder.Build();

app.MapControllers();

app.Run();