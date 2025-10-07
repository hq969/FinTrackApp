using Microsoft.Maui.Controls;

namespace MyFinanceApp.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnViewTransactionsClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Transactions");
    }

    private async void OnOpenReports(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Reports");
    }
}
