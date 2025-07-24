using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Configurations;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Infrastructure.Repositories
{
    
    public class TransactionRepository : ITransactionRepository
    {
        private readonly IMongoCollection<Transaction> _collection;

        public TransactionRepository(IOptions<MongoDbSettings> settings)
        {
            Console.WriteLine("ConnectionString recebida: " + settings.Value.ConnectionString);
            Console.WriteLine("DatabaseName recebido: " + settings.Value.DatabaseName);
            Console.WriteLine("CollectionName recebido: " + settings.Value.CollectionName);

            var client = new MongoClient(settings.Value.ConnectionString);
            var database = client.GetDatabase(settings.Value.DatabaseName);
            _collection = database.GetCollection<Transaction>(settings.Value.CollectionName);
        }

        public async Task<IEnumerable<Transaction>> GetAllAsync()
        {
            return await _collection.Find(_ => true).ToListAsync();
        }

        public async Task CreateAsync(Transaction transaction)
        {
            await _collection.InsertOneAsync(transaction);
        }
    }
}
