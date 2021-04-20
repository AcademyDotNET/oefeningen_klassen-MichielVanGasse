using System;
using System.Collections.Generic;

namespace Speelkaarten
{
	class Program
	{
		static void Main(string[] args)
		{
			if (OperatingSystem.IsWindows()) // prevent warning windows only
			{
				Console.SetWindowSize(44, 15);
			}

			Console.BackgroundColor = ConsoleColor.White;

			List <Speelkaart> deck = new List<Speelkaart>();
			Random rand = new Random();

			for (int i = 1; i <= 13; i++)
			{
				deck.Add(new Speelkaart(i.ToString(), '♠', ConsoleColor.Black));
				deck.Add(new Speelkaart(i.ToString(), '♦', ConsoleColor.Red));
				deck.Add(new Speelkaart(i.ToString(), '♥', ConsoleColor.Red));
				deck.Add(new Speelkaart(i.ToString(), '♣', ConsoleColor.Black));
			}

			Console.CursorVisible = false;
			do
			{
				Console.Clear();
				int showCard = rand.Next(0, deck.Count);
				Console.ForegroundColor = deck[showCard].Color;
				Console.WriteLine(deck[showCard].DrawCard());
				//Console.WriteLine(deck.Count);
				deck.RemoveAt(showCard);

				Console.ReadLine();
			} while (deck.Count != 0);
		}
	}
}
