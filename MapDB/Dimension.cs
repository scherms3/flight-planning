using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIOSDigital.MapDB
{
    public struct Dimension
    {
        public readonly int Height;
        public readonly int Width;

        public Dimension(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
    }
}
