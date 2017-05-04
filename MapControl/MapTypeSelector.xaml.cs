using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using CIOSDigital.MapDB;

namespace CIOSDigital.MapControl
{
    /// <summary>
    /// Interaction logic for MapTypeSelector.xaml
    /// </summary>
    public partial class MapTypeSelector : UserControl
    {
        public MapType MapType { get; private set; }

        public MapTypeSelector()
        {
            InitializeComponent();
            this.MapType = (MapType) this.DefaultButton.Tag;
        }

        private void ButtonClicked(object sender, RoutedEventArgs e)
        {
            Grid container = (Grid) sender;
            Button source = (Button) e.Source;
            foreach (Button b in container.Children.OfType<Button>())
            {
                bool is_sender = (b == source);
                b.IsEnabled = !is_sender;
                if (is_sender)
                {
                    this.MapType = (MapType)b.Tag;
                }
            }
        }
    }
}
