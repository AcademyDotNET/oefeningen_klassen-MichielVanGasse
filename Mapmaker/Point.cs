using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapmaker
{
	class Point
	{
        int x;
        int y;
        public Point(int inx, int iny)
        {
            x = inx;
            y = iny;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}
