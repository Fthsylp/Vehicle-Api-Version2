using VehicleApiVersion2.Data;
using VehicleApiVersion2.Data.IRepository;
using VehicleApiVersion2.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<applicationContext>();

builder.Services.AddScoped<ICarRepository, CarRepository>(serviceProvider =>
    new CarRepository(serviceProvider.GetRequiredService<applicationContext>()));
builder.Services.AddScoped<IBoatRepository, BoatRepository>(serviceProvider =>
    new BoatRepository(serviceProvider.GetRequiredService<applicationContext>()));
builder.Services.AddScoped<IBusRepository, BusRepository>(serviceProvider =>
    new BusRepository(serviceProvider.GetRequiredService<applicationContext>()));


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
