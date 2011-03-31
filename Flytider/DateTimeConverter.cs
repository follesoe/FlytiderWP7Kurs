using System;
using System.Globalization;
using System.Windows.Data;

namespace Flytider
{
    public class DateTimeToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter == null)
                return ((DateTime) value).ToString(culture);
            else
                return ((DateTime)value).ToString(parameter as string, culture);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
