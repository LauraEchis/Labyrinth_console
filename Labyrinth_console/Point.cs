using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    public class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector(int new_x, int new_y)
        {
            this.X = new_x;
            this.Y = new_y;
        }

        public void ToTheRight()
        {
            var tmp = this.X;
            this.X = this.Y * -1;
            this.Y = tmp;
        }

        public void ToTheLeft()
        {
            var tmp = this.X;
            this.X = this.Y;
            this.Y = tmp * -1;
        }
    }
}