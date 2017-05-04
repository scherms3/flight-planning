using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIOSDigital.FlightPlan
{
    public class Plan
    {
        private readonly List<Coordinate> Waypoints;
        
        private Plan()
        {
            Waypoints = new List<Coordinate>();
        }

        public Plan Empty()
        {
            return new Plan();
        }
    }
}
