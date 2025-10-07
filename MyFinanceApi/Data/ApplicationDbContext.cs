using Microsoft.EntityFrameworkCore;
using MyFinanceApi.Models;

namespace MyFinanceApi.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Transaction> Transactions { get; set; }
}
