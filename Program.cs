using CQRSMediatR_Example.Context;
using CQRSMediatR_Example.CQRS.Handlers.CommandHandlers;
using CQRSMediatR_Example.CQRS.Handlers.QueryHandlers;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<CreateProductCommandHandler>());

//builder.Services.AddTransient<CreateProductCommandHandler>();
//builder.Services.AddTransient<DeleteProductCommandHandler>();
//builder.Services.AddTransient<GetAllProductQueryHandler>();
//builder.Services.AddTransient<GetByIdProductQueryHandler>();

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
