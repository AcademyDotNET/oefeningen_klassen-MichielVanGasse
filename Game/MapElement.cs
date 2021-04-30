using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	abstract class MapElement
	{
		public char drawChar;
		public Point Location { get; set; } = new Point();
		public MapElement(char drawChar)
		{
			this.drawChar = drawChar;
		}
		public virtual void Draw()
		{
			Console.SetCursorPosition(Location.X+30,Location.Y+3);
			Console.Write(drawChar);
			Console.ResetColor();
		}
		public override string ToString()
		{
			return $"{drawChar} {Location.X} {Location.Y} ";
		}

	}
}
