using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapmaker
{
    abstract class MapObject
    {
        private Point location;
        private double price;
        private char drawChar;


        public char DrawChar { get; set; }
        public double Price { get; set; }
        public Point Location { get; set; }
		//Teken object in de console
		public abstract void Paint();
    }
}
