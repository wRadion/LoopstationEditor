using System;
using System.Globalization;
using System.Windows.Data;

namespace LoopstationEditor.Converters.Loopstation
{
    public class AddIntConverter : IValueConverter
    {
        public int Value { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToInt32(value) + Value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToInt32(value) - Value;
        }
    }
}
