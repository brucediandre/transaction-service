using Application.Interfaces;
using Domain.Entities;

namespace Application.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _repository;

        public TransactionService(ITransactionRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Transaction>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task CreateAsync(Transaction transaction)
        {
            transaction.Id = Guid.NewGuid().ToString();
            transaction.CreatedAt = DateTime.UtcNow;
            await _repository.CreateAsync(transaction);
        }
    }
}
