using Microsoft.AspNetCore.Mvc;
using MyFinanceApi.Data;
using MyFinanceApi.Models;

namespace MyFinanceApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TransactionsController : ControllerBase
{
    private readonly ApplicationDbContext _db;
    public TransactionsController(ApplicationDbContext db) => _db = db;

    [HttpGet]
    public IActionResult Get() => Ok(_db.Transactions.ToList());

    [HttpPost]
    public IActionResult Create([FromBody] Transaction t)
    {
        t.Id = _db.Transactions.Count() + 1;
        _db.Transactions.Add(t);
        _db.SaveChanges();
        return CreatedAtAction(nameof(Get), new { id = t.Id }, t);
    }

    [HttpPost("sync")]
    public IActionResult Sync([FromBody] IEnumerable<Transaction> txns)
    {
        foreach (var t in txns)
        {
            t.Id = _db.Transactions.Count() + 1;
            _db.Transactions.Add(t);
        }
        _db.SaveChanges();
        return Ok(new { success = true, received = txns.Count() });
    }
}
