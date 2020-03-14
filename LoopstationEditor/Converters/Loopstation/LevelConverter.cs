using System;
using System.Globalization;
using System.Windows.Data;

namespace LoopstationEditor.Converters.Loopstation
{
    public class LevelConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((int)value) * 2;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int i = 0;

            if (value is double d)
                i = (int)d;
            else if (value is float f)
                i = (int)f;
            else
                i = (int)value;

            return i / 2;
        }
    }
}
