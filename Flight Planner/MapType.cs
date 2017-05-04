using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIOSDigital.FlightPlanner
{
    public enum MapType
    {
        RoadMap,
        Terrain,
        Satellite,
        Hybrid
    }

    public static class MapTypeMethods
    {
        public static String ToGoogleMapsAPIString(this MapType dis)
        {
            switch (dis)
            {
                default:
                case MapType.RoadMap:
                    return "roadmap";
                case MapType.Terrain:
                    return "terrain";
                case MapType.Satellite:
                    return "satellite";
                case MapType.Hybrid:
                    return "hybrid";
            }
        }
    }
}
