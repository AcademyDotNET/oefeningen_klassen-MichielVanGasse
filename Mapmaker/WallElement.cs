using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapmaker
{
    class WallElement : MapObject
    {
		public WallElement(Point location ,char character, double price)
		{
            Location = location;
            DrawChar = character;
            Price = price;
		}
        public override void Paint()
        {
            Console.SetCursorPosition(Location.X, Location.Y);
            Console.Write(DrawChar);
        }
    }
}
