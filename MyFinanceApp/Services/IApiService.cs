using MyFinanceApp.Models;

namespace MyFinanceApp.Services;

public interface IApiService
{
    Task<bool> PushTransactionsAsync(IEnumerable<Transaction> transactions);
    Task<List<Transaction>> FetchRemoteTransactionsAsync();
}
