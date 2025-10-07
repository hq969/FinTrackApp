using Microsoft.Maui.Controls;
using MyFinanceApp.ViewModels;

namespace MyFinanceApp.Views;

public partial class TransactionsPage : ContentPage
{
    TransactionsViewModel _vm;
    public TransactionsPage(TransactionsViewModel vm)
    {
        InitializeComponent();
        _vm = vm;
        BindingContext = vm;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _vm.LoadAsync();
    }
}
