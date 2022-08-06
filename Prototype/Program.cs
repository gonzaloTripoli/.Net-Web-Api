using Microsoft.EntityFrameworkCore;
using Prototype.DAL;
using Prototype.Services.Interfaces;
using Prototype.Services.Services;
using Prototype.Services.ViewModels.Customer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<ICustomerService,CustomerService>();
builder.Services.AddDbContext<PrototypeDbContext>(
        options => options.UseSqlServer("Server=.;Database=PrototypeDB;Trusted_Connection=True"));
builder.Services.AddAutoMapper(typeof(CustomerCreateViewModel).Assembly);

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
