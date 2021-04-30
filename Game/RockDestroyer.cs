using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	class RockDestroyer : Monster, IDestroyer
	{
		public RockDestroyer(int x, int y) : base('D')
		{
			Location.X = x;
			Location.Y = y;
		}
		public override void Draw()
		{
			Console.BackgroundColor = ConsoleColor.Red;
			Console.ForegroundColor = ConsoleColor.Black;
			base.Draw();
		}
		public void Shoot()
		{
			Console.Clear();
			Console.BackgroundColor = ConsoleColor.Red;
			Console.Clear();
			Console.SetCursorPosition(35, 20);
			Console.WriteLine(@"
				
				





      ██╗   ██╗ ██████╗ ██╗   ██╗    ██╗  ██╗ █████╗ ██╗   ██╗███████╗        
      ╚██╗ ██╔╝██╔═══██╗██║   ██║    ██║  ██║██╔══██╗██║   ██║██╔════╝        
       ╚████╔╝ ██║   ██║██║   ██║    ███████║███████║██║   ██║█████╗          
        ╚██╔╝  ██║   ██║██║   ██║    ██╔══██║██╔══██║╚██╗ ██╔╝██╔══╝          
         ██║   ╚██████╔╝╚██████╔╝    ██║  ██║██║  ██║ ╚████╔╝ ███████╗        
         ╚═╝    ╚═════╝  ╚═════╝     ╚═╝  ╚═╝╚═╝  ╚═╝  ╚═══╝  ╚══════╝        
                                                                        
   ██████╗ ███████╗███████╗███╗   ██╗    ███████╗██╗  ██╗ ██████╗ ████████╗
   ██╔══██╗██╔════╝██╔════╝████╗  ██║    ██╔════╝██║  ██║██╔═══██╗╚══██╔══╝
   ██████╔╝█████╗  █████╗  ██╔██╗ ██║    ███████╗███████║██║   ██║   ██║   
   ██╔══██╗██╔══╝  ██╔══╝  ██║╚██╗██║    ╚════██║██╔══██║██║   ██║   ██║   
   ██████╔╝███████╗███████╗██║ ╚████║    ███████║██║  ██║╚██████╔╝   ██║   
   ╚═════╝ ╚══════╝╚══════╝╚═╝  ╚═══╝    ╚══════╝╚═╝  ╚═╝ ╚═════╝    ╚═╝   
                                                                        
                                                                                                   
                                                                                                      






");
			Console.ReadLine();
			Program.play = false;
			Console.ResetColor();
			Console.Clear();
		}
		protected override bool Action(MapElement[,] playField)
		{
			if (this is RockDestroyer)
			{
				if (playField[Location.X - 1, Location.Y] is Player || playField[Location.X - 1, Location.Y] is Rock)
				{
					if (playField[Location.X - 1, Location.Y] is Player)
					{
						Shoot();
					}
					Program.RemoveMapElement(Location.X - 1, Location.Y);
					return true;
				}
			}
			return false;
		}
		public override string ToString()
		{
			return $"Rock destoryer {Location.X} {Location.Y} ";
		}
	}
}
