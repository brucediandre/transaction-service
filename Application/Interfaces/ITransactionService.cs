using Domain.Entities;

namespace Application.Interfaces
{
    public interface ITransactionService
    {
        Task<IEnumerable<Transaction>> GetAllAsync();
        Task CreateAsync(Transaction transaction);
    }
}
