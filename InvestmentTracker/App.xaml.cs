using InvestmentTracker.Views;
namespace InvestmentTracker;
public partial class App : Application
{
    public static DatabaseService DatabaseService { get; private set; }
    public static ApiService ApiService { get; private set; }

    public App()
    {
        InitializeComponent();
        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "investments.db3");
        DatabaseService = new DatabaseService(dbPath);
        ApiService = new ApiService();
        MainPage = new NavigationPage(new PortfolioPage());
    }
}
