using System;
using System.Globalization;

namespace PlatziMauiApp.Views.Converters
{
    public class AgeToStatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string text = $"{value}";

            if (!string.IsNullOrEmpty(text))
            {
                if (int.Parse(text) >= 21)
                {
                    return "You're an adult!";
                }
                else
                {
                    return "You are a minor!";
                }
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return string.Empty;
        }
    }
}

