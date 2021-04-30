using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	enum SelectedAction { MoveUp, MoveRight, MoveDown, MoveLeft, Shoot }
	class Player : MapElement, IMoveable, IDestroyer
	{
		private static string[] selectMenu = { "Move Up", "Move Right", "Move Down", "Move Left", "Shoot" };
		private static int selection = 0;
		public Player() : base('X')
		{

		}
		public Player(int x, int y) : base('X')
		{
			Location.X = x;
			Location.Y = y;
		}
		public override void Draw()
		{
			Console.BackgroundColor = ConsoleColor.Blue;
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

		public void Shoot()
		{
			Console.Clear();
			Console.BackgroundColor = ConsoleColor.Green;
			Console.Clear();
			Console.ResetColor();
			Console.Clear();
		}
		private SelectedAction SelectPlayerAction()
		{
			// 1 van de 4 richtingen OF schieten
			//Console.WriteLine("1 up 4 richtingen OF schieten");
			ConsoleKey keyDown; // to store the pressed key

			do
			{
				DrawMenu(selection, selectMenu);

				ConsoleKeyInfo keyInfo = Console.ReadKey(true); //get the pressed key
				keyDown = keyInfo.Key; //safe the pressed key

				if (keyDown == ConsoleKey.UpArrow || keyDown == ConsoleKey.Z)
				{
					selection--;
					if (selection == -1)
					{
						selection = selectMenu.Length - 1;
					}
				}
				if (keyDown == ConsoleKey.DownArrow || keyDown == ConsoleKey.S)
				{
					selection++;
					if (selection == selectMenu.Length)
					{
						selection = 0;
					}
				}
			} while (keyDown != ConsoleKey.Enter);

			return (SelectedAction)selection;
		}
		private void DrawMenu(int selection, string[] selectMenu)
		{
			// selection to highlight the selected menu
			// cycles trough the selected menu

			for (int i = 0; i < selectMenu.Length; i++)
			{
				// +6 for the >>  << extra to find the middle of the option to put in the middle of the screen
				Console.SetCursorPosition(40 - (selectMenu[i].Length + 6) / 2, 25 + i);

				if (i == selection)
				{
					Console.ForegroundColor = ConsoleColor.Black;
					Console.BackgroundColor = ConsoleColor.White;
					Console.Write($">> {selectMenu[i]} <<");
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.White;
					Console.BackgroundColor = ConsoleColor.Black;
					Console.Write($"   {selectMenu[i]}   ");
				}
			}
		}
		public void ExecutePlayerAction(MapElement[,] playField)
		{
			bool ValidAction = false;

			do
			{
				SelectedAction selectedAction = SelectPlayerAction();

				switch (selectedAction)
				{
					case SelectedAction.MoveUp:
						if (Location.Y > 0 && playField[Location.X, Location.Y - 1] == null)
						{
							MoveUp();
							ValidAction = true;
						}
						break;
					case SelectedAction.MoveRight:
						if (Location.X < 19 && playField[Location.X + 1, Location.Y] == null)
						{
							MoveRight();
							ValidAction = true;
						}
						break;
					case SelectedAction.MoveDown:
						if (Location.Y < 19 && playField[Location.X, Location.Y + 1] == null)
						{
							MoveDown();
							ValidAction = true;
						}
						break;
					case SelectedAction.MoveLeft:
						if (Location.X > 0 && playField[Location.X - 1, Location.Y] == null)
						{
							MoveLeft();
							ValidAction = true;
						}
						break;
					case SelectedAction.Shoot:
						if (playField[Location.X + 1, Location.Y] is Rock || playField[Location.X + 1, Location.Y] is Monster)
						{
							Shoot();
							Program.RemoveMapElement(Location.X + 1, Location.Y);
							ValidAction = true;
						}
						break;
					default:
						break;
				}
			} while (!ValidAction);
		}
		public override string ToString()
		{
			return $"Player {Location.X} {Location.Y} ";
		}
	}
}
