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

			do
			{
				Console.Clear();
				for (int i = 0; i < webSites.Length; i++)
				{
					Console.WriteLine($"{i + 1} { webSites[i].Naam} : { webSites[i].URL}");
				}

				Console.WriteLine("1 wil je een website aanpassen?\n2 wil je een website openen?");
				string choice = Console.ReadLine();

				if (choice == "1")
				{
					int input = InputCheckInt("Geef nr welke je wil wijzigen.");
					webSites[input] = new BookMark();
					Console.WriteLine("Geef website naam");
					webSites[input].Naam = Console.ReadLine();

					Console.WriteLine("Geef url");
					webSites[input].URL = Console.ReadLine();
				}
				if (choice == "2")
				{
					webSites[InputCheckInt("Geef nummber welke site wil je openen?")].OpenSite();
				}
			} while (true);
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
