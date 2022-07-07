using Laminin.PowerCurve.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var config = new PowerCurveConfig(
    builder.Configuration.GetSection("Sbsa:AuthUrl").Value,
    builder.Configuration.GetSection("Sbsa:ApiUrl").Value,
    builder.Configuration.GetSection("Sbsa:ClientId").Value,
    builder.Configuration.GetSection("Sbsa:ClientSecret").Value,
    builder.Configuration.GetConnectionString("PowerCurveDb")
);

builder.Services.AddSingleton(config);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
