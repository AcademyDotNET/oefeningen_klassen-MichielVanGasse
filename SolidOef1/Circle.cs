using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidOef1
{
	class Circle : Shape
    {
        public int straal;
        public Circle(int straal)
        {
            this.straal = straal;
        }
        public override double Opp()
        {
            return straal * straal * Math.PI;
        }
    }
}
