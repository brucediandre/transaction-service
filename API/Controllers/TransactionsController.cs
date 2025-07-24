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
        public IActionResult Get()
        {
            var transactions = _transactionService.GetAll();
            return Ok(transactions);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Transaction transaction)
        {
            _transactionService.Create(transaction);
            return CreatedAtAction(nameof(Get), new { id = transaction.Id }, transaction);
        }
    }
}
