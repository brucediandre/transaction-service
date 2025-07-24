using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Application.Interfaces;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionsController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var transactions = await _transactionService.GetAllAsync();
            return Ok(transactions);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Transaction transaction)
        {
            await _transactionService.CreateAsync(transaction);
            return CreatedAtAction(nameof(Get), new { id = transaction.Id }, transaction);
        }
    }
}
