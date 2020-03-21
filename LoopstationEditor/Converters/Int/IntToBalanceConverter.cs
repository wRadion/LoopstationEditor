using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace LoopstationEditor.Converters.Int
{
    public class IntToBalanceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return DependencyProperty.UnsetValue;

            int i = (int)value;

            return $"{i}:{100 - i}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
