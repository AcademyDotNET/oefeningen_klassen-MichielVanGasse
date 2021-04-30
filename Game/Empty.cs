using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	class Empty : MapElement
	{
		public Empty() : base('█')
		{

		}
		public Empty(int x, int y) : base('█')
		{
			Location.X = x;
			Location.Y = y;
		}
		public override void Draw()
		{
			if ((Location.X + Location.Y) % 2 == 0)
			{
				Console.ForegroundColor = ConsoleColor.Black;
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.DarkGray;
			}
			base.Draw();
		}
	}
}
