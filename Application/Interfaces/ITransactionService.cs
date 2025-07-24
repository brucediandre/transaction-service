using Domain.Entities;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface ITransactionService
    {
        IEnumerable<Transaction> GetAll();
        void Create(Transaction transaction);
    }
}
