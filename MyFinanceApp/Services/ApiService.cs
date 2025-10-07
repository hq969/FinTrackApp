using System.Net.Http.Json;
using MyFinanceApp.Models;

namespace MyFinanceApp.Services;

public class ApiService : IApiService
{
    private readonly HttpClient _http;
    private readonly string _baseUrl;

    public ApiService()
    {
        _baseUrl = "http://localhost:5000/api"; // change to your API address or emulator address
        _http = new HttpClient(){ BaseAddress = new Uri(_baseUrl) };
    }

    public async Task<bool> PushTransactionsAsync(IEnumerable<Transaction> transactions)
    {
        try
        {
            var res = await _http.PostAsJsonAsync("/transactions/sync", transactions);
            return res.IsSuccessStatusCode;
        }
        catch
        {
            return false;
        }
    }

    public async Task<List<Transaction>> FetchRemoteTransactionsAsync()
    {
        try
        {
            return await _http.GetFromJsonAsync<List<Transaction>>("/transactions") ?? new List<Transaction>();
        }
        catch
        {
            return new List<Transaction>();
        }
    }
}
