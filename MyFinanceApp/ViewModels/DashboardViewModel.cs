using CommunityToolkit.Mvvm.ComponentModel;
using MyFinanceApp.Services;

namespace MyFinanceApp.ViewModels;

public partial class DashboardViewModel : ObservableObject
{
    private readonly ILocalDatabase _db;

    public DashboardViewModel(ILocalDatabase db)
    {
        _db = db;
    }

    // Add properties for totals, charts, etc.
}
