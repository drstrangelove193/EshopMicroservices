var builder = WebApplication.CreateBuilder(args);

// Add Services to the DI Container
builder.Services.AddCarter();

builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssemblies(typeof(Program).Assembly);
});

var app = builder.Build();

// Configure the HTTP Pipeline
app.MapCarter();

app.Run();
