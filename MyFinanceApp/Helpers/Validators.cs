
using System.Text.RegularExpressions;

namespace MyFinanceApp.Helpers
{
    public static class Validators
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }

        public static bool IsValidAmount(decimal amount)
        {
            return amount > 0;
        }

        public static bool IsValidPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 6) return false;
            return Regex.IsMatch(password, @"\d");
        }
    }
}
