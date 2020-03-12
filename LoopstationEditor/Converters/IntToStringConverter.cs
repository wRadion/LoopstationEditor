using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace LoopstationEditor.Converters
{
    public class IntToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string str = value.ToString();

            if (string.IsNullOrWhiteSpace(str))
                return DependencyProperty.UnsetValue;

            return int.Parse(str);
        }
    }
}
