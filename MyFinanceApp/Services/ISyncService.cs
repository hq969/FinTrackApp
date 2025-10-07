using MyFinanceApp.Models;

namespace MyFinanceApp.Services;

public interface ISyncService
{
    Task SyncAsync();
}
