using System;
using System.Collections.Generic;

namespace Game
{
	class Program
	{
		public static Random rand = new Random();
		private static List<MapElement> mapElements = new List<MapElement>();
		private static MapElement[,] playField = new MapElement[20, 20];
		private static MapElement[,] playFieldBackground = new MapElement[20, 20];
		private static Player player;
		public static bool play = true;
		static void Main(string[] args)
		{
			// prevent warning windows only
			if (OperatingSystem.IsWindows())
			{
				Console.SetWindowSize(80, 35);
			}
			Console.CursorVisible = false;

			// fill playfield
			AddRandomMonstersRocks(50);
			mapElements.Add(new Player(0, 10));
			UpdatePlayField();
			SetEmptyFields();
			GetPlayer();

			do
			{
				Console.WriteLine(mapElements[0]);
				DrawArray(playFieldBackground);
				DrawArray(playField);
				player.ExecutePlayerAction(playField);
				UpdatePlayField();
				MoveAi();
				Victory();
			} while (play);
		}
		private static void MoveAi()
		{
			for (int i = 0; i < mapElements.Count; i++)
			{
				if(mapElements[i] is Monster)
				{
					Monster monster = (Monster)mapElements[i];
					monster.MoveValidationMonster(playField);
					UpdatePlayField();
				}else if (mapElements[i] is RockDestroyer)
				{
					RockDestroyer rockDestroyer = (RockDestroyer)mapElements[i];
					rockDestroyer.MoveValidationMonster(playField);
					UpdatePlayField();
				}
			}
		}
		private static void Victory()
		{
			if (player.Location.X == 19)
			{
				play = false;
				Console.Clear();
				Console.BackgroundColor = ConsoleColor.Green;
				Console.Clear();
				Console.WriteLine(@"












	   ██╗   ██╗██╗ ██████╗████████╗ ██████╗ ██████╗ ██╗   ██╗
	   ██║   ██║██║██╔════╝╚══██╔══╝██╔═══██╗██╔══██╗╚██╗ ██╔╝
	   ██║   ██║██║██║        ██║   ██║   ██║██████╔╝ ╚████╔╝ 
	   ╚██╗ ██╔╝██║██║        ██║   ██║   ██║██╔══██╗  ╚██╔╝  
	    ╚████╔╝ ██║╚██████╗   ██║   ╚██████╔╝██║  ██║   ██║   
	     ╚═══╝  ╚═╝ ╚═════╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝   ╚═╝   
                          









");
				Console.ReadLine();
			}
		}
		private static void UpdatePlayField()
		{
			playField = new MapElement[20, 20];
			foreach (var item in mapElements)
			{
				playField[item.Location.X, item.Location.Y] = item;
			}
		}
		public static void GetPlayer()
		{
			for (int i = 0; i < mapElements.Count; i++)
			{
				if (mapElements[i] is Player)
				{
					player = (Player)mapElements[i];
				}
			} 
		}
		private static void DrawArray(MapElement[,] playField)
		{
			foreach (var element in playField)
			{
				if (element != null)
					element.Draw();
			}
		}
		private static void AddRandomMonstersRocks(int amount)
		{
			for (int i = 0; i < amount; i++)
			{
				int xRand, yRand, index = 0;
				bool filledPosition = true;

				do
				{
					xRand = rand.Next(1, 20);
					yRand = rand.Next(1, 20);
					if (i < amount / 3 && playField[xRand, yRand] == null)
					{
						mapElements.Add(new Monster(xRand, yRand));
						playField[mapElements[index].Location.Y, mapElements[index].Location.X] = mapElements[index];
						filledPosition = false;
						index++;
					}
					else if (i < (amount * 2) / 3 && playField[xRand, yRand] == null)
					{
						mapElements.Add(new Rock(xRand, yRand));
						playField[mapElements[index].Location.Y, mapElements[index].Location.X] = mapElements[index];
						filledPosition = false;
						index++;
					}
					else if (playField[xRand, yRand] == null)
					{
						mapElements.Add(new RockDestroyer(xRand, yRand));
						playField[mapElements[index].Location.Y, mapElements[index].Location.X] = mapElements[index];
						filledPosition = false;
						index++;
					}
				}
				while (filledPosition);
			}
		}
		private static void SetEmptyFields()
		{
			for (int i = 0; i < playFieldBackground.GetLength(0); i++)
			{
				for (int j = 0; j < playFieldBackground.GetLength(1); j++)
				{
					playFieldBackground[i, j] = new Empty(i, j);
				}
			}
		}
		public static void RemoveMapElement(int x, int y)
		{
			for (int i = 0; i < mapElements.Count; i++)
			{
				if (mapElements[i].Location.X == x && mapElements[i].Location.Y == y)
				{
					mapElements.RemoveAt(i);
				}
			}
		}
	}
}
