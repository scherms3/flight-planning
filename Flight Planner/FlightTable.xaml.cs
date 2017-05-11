using CIOSDigital.FlightPlan;
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

namespace CIOSDigital.FlightPlanner
{
    public partial class FlightTable : UserControl
    {
        public static readonly DependencyProperty ActivePlanProperty =
            DependencyProperty.Register("ActivePlan", typeof(Plan), typeof(FlightTable));
        public Plan ActivePlan {
            get {
                return this.GetValue(ActivePlanProperty) as Plan;
            }
            set {
                this.SetValue(ActivePlanProperty, value);
                this.Table.ItemsSource = value;
            }
        }

        public FlightTable()
        {
            InitializeComponent();
        }

        public void Refresh()
        {
            foreach (Coordinate c in this.ActivePlan)
            {
                Console.WriteLine("Refreshing with coordinate {0}, {1}", c.Latitude, c.Longitude);
            }
            this.Table.Items.Refresh();
        }
    }
}
