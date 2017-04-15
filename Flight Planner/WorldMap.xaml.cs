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

namespace CIOSDigital.FlightPlanner
{
    /// <summary>
    /// Interaction logic for WorldMap.xaml
    /// </summary>
    public partial class WorldMap : UserControl
    {
        public bool MouseIsDown { get; private set; }
        public Point MousePosition { get; private set; }

        private int _ZoomLevel;
        public int ZoomLevel {
            get {
                return _ZoomLevel;
            }
            private set {
                _ZoomLevel = Math.Min(Math.Max(value, 6), 13);
            }
        }
        public Point Coordinates { get; private set; }

        public WorldMap()
        {
            this.MouseIsDown = false;
            this.MousePosition = new Point(0, 0);
            this.Coordinates = new Point(-47, -123);
            this.ZoomLevel = 6;
            InitializeComponent();
        }

        private void Button_Plus_Click(object sender, RoutedEventArgs e)
        {
            this.PerformZoom(1);
        }

        private void Button_Minus_Click(object sender, RoutedEventArgs e)
        {
            this.PerformZoom(-1);
        }

        private void Root_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            this.PerformZoom(Math.Sign(e.Delta));
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

        private void PerformZoom(int delta)
        {
            Debug.Assert(delta == 1 || delta == -1);
            this.ZoomLevel += delta;
            if (delta == 1)
            {
                Console.WriteLine("Zoom in");
            }
            else
            {
                Console.WriteLine("Zoom out");
            }
        }
    }
}
