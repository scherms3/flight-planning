using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CIOSDigital.MapControl
{
    /// <summary>
    /// Interaction logic for ZoomSelector.xaml
    /// </summary>
    public partial class ZoomSelector : UserControl
    {
        public decimal ZoomLevel { get; private set; }

        public ZoomSelector()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Console.WriteLine("{0} -> {1}", e.OldValue, e.NewValue);
        }
    }
}
