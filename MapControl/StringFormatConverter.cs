using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CIOSDigital.MapControl
{
    public class StringFormatConverter : IValueConverter
    {
        public string FormatString { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return String.Format(this.FormatString, value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
