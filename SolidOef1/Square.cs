using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidOef1
{
	class Square : Shape
    {
        public int lengte;
        public Square(int l)
        {
            lengte = l;
        }
        public override double Opp()
        {
            return lengte * lengte;
        }
    }
}
