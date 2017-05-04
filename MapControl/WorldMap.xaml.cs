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
using CIOSDigital.FlightPlan;
using CIOSDigital.MapDB;

namespace CIOSDigital.MapControl
{
    /// <summary>
    /// Interaction logic for WorldMap.xaml
    /// </summary>
    public partial class WorldMap : UserControl
    {
        private decimal ZoomLevel {
            get {
                return this.ZoomSelector.ZoomLevel;
            }
        }
        private MapType MapType {
            get {
                return this.TypeSelector.MapType;
            }
        }
        private Point Coordinates { get; set; }

        private MapProvider ImageSource { get; set; }
        private Plan ActivePlan { get; set; }

        private bool MouseIsDown { get; set; }
        private Point MousePosition { get; set; }

        public WorldMap()
        {
            this.MouseIsDown = false;
            this.MousePosition = new Point(0, 0);
            this.Coordinates = new Point(47.62, -122.35);
            InitializeComponent();
        }

        private void Root_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.MouseIsDown = true;
            this.MousePosition = e.GetPosition(this);
        }

        private void Root_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.MouseIsDown = false;
        }

        private void Root_MouseLeave(object sender, MouseEventArgs e)
        {
            this.MouseIsDown = false;
        }

        private void Root_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseIsDown)
            {
                Point previous = this.MousePosition;
                this.MousePosition = e.GetPosition(this);
                Vector delta = Point.Subtract(previous, this.MousePosition);
                this.PerformScrollBy(delta);
            }
        }

        private void PerformScrollBy(Vector delta)
        {
            foreach (UIElement child in this.Picture.Children)
            {
                double x = (double)child.GetValue(Canvas.LeftProperty);
                double y = (double)child.GetValue(Canvas.TopProperty);
                Canvas.SetLeft(child, x - delta.X);
                Canvas.SetTop(child, y - delta.Y);
            }
            Picture.UpdateLayout();
        }
    }
}
