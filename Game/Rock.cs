using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	class Rock : MapElement
	{
		public Rock() : base('R')
		{

		}
		public Rock(int x, int y) : base('R')
		{
			Location.X = x;
			Location.Y = y;
		}
		public override void Draw()
		{
			Console.BackgroundColor = ConsoleColor.Gray;
			Console.ForegroundColor = ConsoleColor.Black;
			base.Draw();
		}
		public override string ToString()
		{
			return $"Rock {Location.X} {Location.Y} ";
		}
	}
}
