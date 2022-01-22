using Microsoft.EntityFrameworkCore;
using PrescriptionAPI.Models.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


//This is the depedency for the appsettings json
ConfigurationManager configuration = builder.Configuration;

//Registering our database
builder.Services.AddDbContext<PrescriptionDataContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
builder.Services.AddScoped<IPrescriptionRepository , PrescriptionRepository>();

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
