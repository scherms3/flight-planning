using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIOSDigital.MapDB
{
    public struct MapImageSpec
    {
        public readonly Coordinate Coordinate;
        public readonly MapType MapType;
        public readonly Dimension Size;
        public readonly decimal Zoom;

        public MapImageSpec(Coordinate coordinate, MapType type, Dimension size, decimal zoom)
        {
            this.Coordinate = coordinate;
            this.MapType = type;
            this.Size = size;
            this.Zoom = zoom;
        }
    }
}
