using SQLite;
using MyFinanceApp.Models;

namespace MyFinanceApp.Services;

public class SqliteLocalDatabase : ILocalDatabase
{
    private SQLiteAsyncConnection? _db;
    private const string DbFile = "finance_app.db3";

    private async Task InitIfNeeded()
    {
        if (_db != null) return;
        var path = Path.Combine(FileSystem.AppDataDirectory, DbFile);
        _db = new SQLiteAsyncConnection(path);
        await _db.CreateTableAsync<Transaction>();
        await _db.CreateTableAsync<Category>();
        await _db.CreateTableAsync<Budget>();
    }

    public async Task InitializeAsync() => await InitIfNeeded();

    public async Task<List<Transaction>> GetTransactionsAsync()
    {
        await InitIfNeeded();
        return await _db!.Table<Transaction>().OrderByDescending(t => t.Date).ToListAsync();
    }

    public async Task AddTransactionAsync(Transaction t)
    {
        await InitIfNeeded();
        await _db!.InsertAsync(t);
    }

    public async Task UpdateTransactionAsync(Transaction t)
    {
        await InitIfNeeded();
        await _db!.UpdateAsync(t);
    }

    public async Task DeleteTransactionAsync(int id)
    {
        await InitIfNeeded();
        await _db!.DeleteAsync<Transaction>(id);
    }

    public async Task<List<Transaction>> GetUnsyncedAsync()
    {
        await InitIfNeeded();
        return await _db!.Table<Transaction>().Where(x => x.IsSynced == false).ToListAsync();
    }

    public async Task MarkSyncedAsync(int id)
    {
        await InitIfNeeded();
        var t = await _db!.FindAsync<Transaction>(id);
        if (t != null) { t.IsSynced = true; await _db.UpdateAsync(t); }
    }
}
