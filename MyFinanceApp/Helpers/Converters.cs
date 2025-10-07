
using System;
using Microsoft.Maui.Controls;

namespace MyFinanceApp.Helpers
{
    public class BoolToStringConverter : IValueConverter
    {
        public string TrueText { get; set; } = "Yes";
        public string FalseText { get; set; } = "No";

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value is bool b && b ? TrueText : FalseText;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value?.ToString() == TrueText;
        }
    }

    public class BoolToColorConverter : IValueConverter
    {
        public Color TrueColor { get; set; } = Colors.Green;
        public Color FalseColor { get; set; } = Colors.Red;

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value is bool b && b ? TrueColor : FalseColor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }
}
