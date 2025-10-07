namespace MyFinanceApi.Models;

public class Transaction
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public DateTime Date { get; set; } = DateTime.UtcNow;
    public string Category { get; set; } = string.Empty;
    public bool IsIncome { get; set; } = false;
}
