using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIOSDigital.FlightPlan
{
    public class Plan : IEnumerable<Coordinate>
    {
        private readonly List<Coordinate> Waypoints;

        private Plan()
        {
            Waypoints = new List<Coordinate>();
        }

        public static Plan Empty()
        {
            return new Plan();
        }

        public void AppendWaypoint(Coordinate c)
        {
            Console.WriteLine("Added waypoint at {0}, {1}", c.Latitude, c.Longitude);
            this.Waypoints.Add(c);
        }

        public IEnumerator<Coordinate> GetEnumerator()
        {
            return ((IEnumerable<Coordinate>)Waypoints).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Coordinate>)Waypoints).GetEnumerator();
        }
    }
}
