namespace MyFinanceApp.Models;

public class Budget
{
    public int Id { get; set; }
    public string Category { get; set; } = string.Empty;
    public decimal Limit { get; set; } = 0m;
    public string Month { get; set; } = string.Empty; // e.g. 2025-10
}
