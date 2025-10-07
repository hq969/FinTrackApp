using MyFinanceApp.Models;

namespace MyFinanceApp.Services;

public class SyncService : ISyncService
{
    private readonly ILocalDatabase _db;
    private readonly IApiService _api;

    public SyncService(ILocalDatabase db, IApiService api)
    {
        _db = db;
        _api = api;
    }

    public async Task SyncAsync()
    {
        var unsynced = await _db.GetUnsyncedAsync();
        if (unsynced.Count == 0) return;

        var ok = await _api.PushTransactionsAsync(unsynced);
        if (ok)
        {
            foreach (var t in unsynced)
                await _db.MarkSyncedAsync(t.Id);
        }
    }
}
