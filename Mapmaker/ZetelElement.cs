using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapmaker
{
    class ZetelElement : FurnitureElement
    {
        public ZetelElement(Point location, double price)
        {
            Location = location;
            Price = price;
            DrawChar = '+';
        }
        public ZetelElement(Point location,  double price, char character)
        {
            Location = location;
            DrawChar = character;
            Price = price;
        }
        public ZetelElement()
        {
            Price = 100;
            DrawChar = '+';
            UnitSize = 2;
        }
        public override void Paint()
        {
            Console.SetCursorPosition(Location.X, Location.Y);
            Console.Write(DrawChar);
        }
    }
}
