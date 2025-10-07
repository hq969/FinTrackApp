
namespace MyFinanceApp.Helpers
{
    public static class Constants
    {
        public const string DatabaseName = "finance_app.db3";
        public const string ApiBaseUrl = "https://localhost:5001/api";
        public static readonly string[] DefaultCategories = 
        {
            "Food", "Transport", "Entertainment", "Bills", "Shopping", "Salary", "Others"
        };
    }
}
