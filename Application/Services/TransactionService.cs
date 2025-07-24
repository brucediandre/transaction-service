using Domain.Entities;
using Application.Interfaces;

namespace Application.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly List<Transaction> _transactions = new(); // Temporário (mock)

        public IEnumerable<Transaction> GetAll()
        {
            return _transactions;
        }

        public void Create(Transaction transaction)
        {
            transaction.Id = Guid.NewGuid().ToString();
            transaction.CreatedAt = DateTime.UtcNow;
            _transactions.Add(transaction);
        }
    }
}
//simulando o armazenamento