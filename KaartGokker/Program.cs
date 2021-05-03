using System;
using System.Collections.Generic;

namespace KaartGokker
{
	class Program
	{
		static void Main(string[] args)
		{
			if (OperatingSystem.IsWindows()) // prevent warning windows only
			{
				Console.SetWindowSize(44, 15);
			}
			Console.CursorVisible = false;
			Console.BackgroundColor = ConsoleColor.White;

			Deck deck = new Deck();
			int score = 0;
			int cardvalue = 0;

			do
			{
				Console.Clear();
				
				Speelkaart speelkaart = deck.ShuffeldDeck.Pop();
				cardvalue += speelkaart.CardValue;
				Console.ForegroundColor = speelkaart.Color;
				Console.WriteLine(speelkaart.DrawCard());

				Console.ForegroundColor = ConsoleColor.Black;
				Console.SetCursorPosition(10, 0);
				Console.WriteLine($"score is {score}");
				Console.SetCursorPosition(10, 1);
				Console.WriteLine($"Total card value is {cardvalue}");

				if (!PlayerInput())
				{
					cardvalue = 0;
				}
			
				if(cardvalue > 21)
				{
					score--;
					cardvalue = 0;
				}
				if (cardvalue == 21)
				{
					score++;
					cardvalue = 0;
				}

			} while (deck.ShuffeldDeck.Count != 0);

			if(score < 0)
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.ForegroundColor = ConsoleColor.White;
				Console.Clear();
				Console.WriteLine(@"
██╗   ██╗ ██████╗ ██╗   ██╗      
╚██╗ ██╔╝██╔═══██╗██║   ██║      
 ╚████╔╝ ██║   ██║██║   ██║      
  ╚██╔╝  ██║   ██║██║   ██║      
   ██║   ╚██████╔╝╚██████╔╝      
   ╚═╝    ╚═════╝  ╚═════╝       
                                 
██╗      ██████╗ ███████╗███████╗
██║     ██╔═══██╗██╔════╝██╔════╝
██║     ██║   ██║███████╗█████╗  
██║     ██║   ██║╚════██║██╔══╝  
███████╗╚██████╔╝███████║███████╗
╚══════╝ ╚═════╝ ╚══════╝╚══════╝                                                                                                                  
");
			}
			else
			{
				Console.BackgroundColor = ConsoleColor.Green;
				Console.ForegroundColor = ConsoleColor.White;
				Console.Clear();
				Console.WriteLine(@"
██╗   ██╗ ██████╗ ██╗   ██╗    
╚██╗ ██╔╝██╔═══██╗██║   ██║    
 ╚████╔╝ ██║   ██║██║   ██║    
  ╚██╔╝  ██║   ██║██║   ██║    
   ██║   ╚██████╔╝╚██████╔╝    
   ╚═╝    ╚═════╝  ╚═════╝     
                               
██╗    ██╗██╗███╗   ██╗        
██║    ██║██║████╗  ██║        
██║ █╗ ██║██║██╔██╗ ██║        
██║███╗██║██║██║╚██╗██║        
╚███╔███╔╝██║██║ ╚████║        
 ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝                                       
");
			}
			Console.ReadLine();
		}

		private static bool PlayerInput()
		{
			bool bet = false;
			do
			{
				ConsoleKeyInfo key = Console.ReadKey();

				if (key.Key == ConsoleKey.UpArrow)
				{
					return true;
				}
				if (key.Key == ConsoleKey.DownArrow)
				{
					return false;
				}
			} while (!bet);
			return false;
		}
	}
}
