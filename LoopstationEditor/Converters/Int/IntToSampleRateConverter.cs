using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace LoopstationEditor.Converters.Int
{
    public class IntToSampleRateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return DependencyProperty.UnsetValue;

            int i = (int)value;

            if (i == 0)
                return "OFF";
            return $"1/{i + 1}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
