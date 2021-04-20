using System;

namespace Bookmark_Manager
{
	class Program
	{
		static void Main(string[] args)
		{
			BookMark[] webSites = new BookMark[5];

			for (int i = 0; i < webSites.Length; i++)
			{
				webSites[i] = new BookMark();
				Console.WriteLine("Geef website naam");
				webSites[i].Naam = Console.ReadLine();

				Console.WriteLine("Geef url");
				webSites[i].URL = Console.ReadLine();
			}
			for (int i = 0; i < webSites.Length; i++)
			{
				Console.WriteLine($"{i + 1} { webSites[i].Naam}");
				Console.WriteLine($"{i + 1} { webSites[i].URL}");
			}
			webSites[InputCheckInt("Geef nummber welke site wil je opslaan?")].WriteTXTStreamWriter();
		}
		static int InputCheckInt(string question)
		{
			int value = 0;
			bool invalid = true;
			do
			{
				Console.WriteLine(question);
				if (Int32.TryParse(Console.ReadLine(), out value))
				{
					if (value <= 5 && value >= 1)
					{
						value--;
						invalid = false;
					}
				}
			} while (invalid);
			return value;
		}
	}
}
