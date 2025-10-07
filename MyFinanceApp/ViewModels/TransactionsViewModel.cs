using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFinanceApp.Models;
using MyFinanceApp.Services;
using System.Collections.ObjectModel;

namespace MyFinanceApp.ViewModels;

public partial class TransactionsViewModel : ObservableObject
{
    private readonly ILocalDatabase _db;
    private readonly ISyncService _sync;

    public ObservableCollection<Transaction> Transactions { get; } = new();

    [ObservableProperty]
    bool isBusy;

    public TransactionsViewModel(ILocalDatabase db, ISyncService sync)
    {
        _db = db;
        _sync = sync;
    }

    [IAsyncRelayCommand]
    public async Task LoadAsync()
    {
        if (IsBusy) return;
        IsBusy = true;
        try
        {
            var items = await _db.GetTransactionsAsync();
            Transactions.Clear();
            foreach (var t in items) Transactions.Add(t);
        }
        finally
        {
            IsBusy = false;
        }
    }

    [IAsyncRelayCommand]
    public async Task AddSampleAsync()
    {
        var t = new Transaction { Title = "Sample Coffee", Amount = 120m, Category = "Food", Date = DateTime.UtcNow, IsIncome = false, IsSynced = false };
        await _db.AddTransactionAsync(t);
        Transactions.Insert(0, t);
    }

    [IAsyncRelayCommand]
    public async Task SyncAsync()
    {
        await _sync.SyncAsync();
    }
}
