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
		public MapObject()
		{
            DrawChar = drawChar;
            Price = price;
            Location = location;
        }

        public char DrawChar { get; set; }
        public double Price { get; set; }
        public Point Location
        {
            get { return location; }
            set
            {
                Point prevloc = location;
                Point offset = new Point(1, 1);
                if (location != null)
                {

                    offset.X = value.X - prevloc.X;
                    offset.Y = value.Y - prevloc.Y;
                }

                location = value;
                if (this is IComposite)
                {
                    IComposite obj = this as IComposite;
                    obj.UpdateElements(offset);
                }

            }
        }
        //Teken object in de console
        public abstract void Paint();
    }
}
