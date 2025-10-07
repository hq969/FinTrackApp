using MyFinanceApp.Models;

namespace MyFinanceApp.Services;

public interface ILocalDatabase
{
    Task InitializeAsync();
    Task<List<Transaction>> GetTransactionsAsync();
    Task AddTransactionAsync(Transaction t);
    Task UpdateTransactionAsync(Transaction t);
    Task DeleteTransactionAsync(int id);
    Task<List<Transaction>> GetUnsyncedAsync();
    Task MarkSyncedAsync(int id);
}
