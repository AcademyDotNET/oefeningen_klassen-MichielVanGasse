using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidOef1
{
	class OppBerekenaar
	{
        List<Shape> lijst;
        public OppBerekenaar(List<Shape> lijst)
        {
            this.lijst = lijst;
        }
        public void VoegToe(Shape shape)
        {
            lijst.Add(shape);
        }
        private double Sum()
        {
            double total = 0;
            foreach (Shape shape in lijst)
            {
                total += shape.Opp();
            }
            return total;
        }
        public string Output()
        {
            return "<h1> Totale som = " + Sum() + " </h1> ";
        }
    }
}
