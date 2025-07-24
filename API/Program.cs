using Application.Interfaces;
using Application.Services;
using Infrastructure.Repositories;
using Infrastructure.Configurations;
using Domain.Entities;

var builder = WebApplication.CreateBuilder(args);
var mongoSettings = builder.Configuration.GetSection("MongoDbSettings").Get<MongoDbSettings>();
Console.WriteLine($"ConnectionString: {mongoSettings?.ConnectionString}");
Console.WriteLine($"DatabaseName: {mongoSettings?.DatabaseName}");
Console.WriteLine($"CollectionName: {mongoSettings?.CollectionName}");


// Configurações do MongoDB
builder.Services.Configure<MongoDbSettings>(
    builder.Configuration.GetSection("MongoDbSettings"));

// Injeção de dependências
builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();
builder.Services.AddScoped<ITransactionService, TransactionService>();

// Serviços da API
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Middlewares
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
