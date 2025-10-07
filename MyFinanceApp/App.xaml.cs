using Microsoft.Maui.Controls;

namespace MyFinanceApp;

public partial class App : Application
{
    public App(AppShell shell)
    {
        InitializeComponent();
        MainPage = shell;
    }
}
