using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	class Monster : MapElement, IMoveable
	{
		char symbol = 'M';
		public Monster() : base('M')
		{

		}
		public Monster(char symbol) : base(symbol)
		{
			this.symbol = symbol;
		}
		public Monster(int x, int y) : base('M')
		{
			Location.X = x;
			Location.Y = y;
		}
		public override void Draw()
		{
			Console.BackgroundColor = ConsoleColor.Green;
			Console.ForegroundColor = ConsoleColor.Black;
			base.Draw();
		}
		public void MoveDown()
		{
			Location.Y++;
		}

		public void MoveLeft()
		{
			Location.X--;
		}

		public void MoveRight()
		{
			Location.X++;
		}

		public void MoveUp()
		{
			Location.Y--;
		}
		public void Eat()
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
                                                                                 
██████╗ ███████╗███████╗███╗   ██╗    ███████╗ █████╗ ████████╗███████╗███╗   ██╗
██╔══██╗██╔════╝██╔════╝████╗  ██║    ██╔════╝██╔══██╗╚══██╔══╝██╔════╝████╗  ██║
██████╔╝█████╗  █████╗  ██╔██╗ ██║    █████╗  ███████║   ██║   █████╗  ██╔██╗ ██║
██╔══██╗██╔══╝  ██╔══╝  ██║╚██╗██║    ██╔══╝  ██╔══██║   ██║   ██╔══╝  ██║╚██╗██║
██████╔╝███████╗███████╗██║ ╚████║    ███████╗██║  ██║   ██║   ███████╗██║ ╚████║
╚═════╝ ╚══════╝╚══════╝╚═╝  ╚═══╝    ╚══════╝╚═╝  ╚═╝   ╚═╝   ╚══════╝╚═╝  ╚═══╝
                                                                                 







");
			Console.ReadLine();
			Program.play = false;
			Console.ResetColor();
		}
		public void MoveValidationMonster(MapElement[,] playField)
		{
			bool ValidAction = false;

			if (Action(playField))
			{
				ValidAction = true;
			}
			else
			{
				int random = 0;
				bool[] inValidAction = new bool[4] { false, false, false, false };

				do
				{
					random = Program.rand.Next(0, 4);

					if (inValidAction.All(x => x))
					{
						ValidAction = true;
					}

					switch (random)
					{
						case 0:
							if (Location.Y > 1 && playField[Location.X, Location.Y - 1] == null)
							{
								MoveUp();
								ValidAction = true;
							}
							inValidAction[0] = true;
							break;
						case 1:
							if (Location.X < 19 && playField[Location.X + 1, Location.Y] == null)
							{
								MoveRight();
								ValidAction = true;
							}
							inValidAction[1] = true;
							break;
						case 2:
							if (Location.Y < 19 && playField[Location.X, Location.Y + 1] == null)
							{
								MoveDown();
								ValidAction = true;
							}
							inValidAction[2] = true;
							break;
						case 3:
							if (Location.X > 1 && playField[Location.X - 1, Location.Y] == null)
							{
								MoveLeft();
								ValidAction = true;
							}
							inValidAction[3] = true;
							break;
						default:
							break;
					}
				} while (!ValidAction);
			}
		}
		protected virtual bool Action(MapElement[,] playField)
		{
			if (this is Monster)
			{
				if (playField[Location.X - 1, Location.Y] is Player)
				{
					Eat();
					Program.RemoveMapElement(Location.X - 1, Location.Y);
					return true;
				}
			}
			return false;
		}
		public override string ToString()
		{
			return $"Monster {Location.X} {Location.Y} ";
		}
	}
}
