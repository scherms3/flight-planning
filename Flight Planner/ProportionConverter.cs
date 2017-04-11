using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CIOSDigital.FlightPlanner
{
    public class ProportionConverter : IValueConverter
    {
        public double Scale { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)(this.Scale * (double)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
