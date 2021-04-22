using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballspel_met_overerving
{
	class Ball2: Ball
	{
		public Ball2(int xin, int yin, int vxin, int vyin): base(xin,  yin,  vxin,  vyin)
		{

		}
		public override void Draw()
		{
			Console.SetCursorPosition(x, y);
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write('#');
			Console.ResetColor();
		}
	}
}
