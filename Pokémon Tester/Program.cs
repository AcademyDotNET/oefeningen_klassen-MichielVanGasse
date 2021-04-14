using System;

namespace Pokémon_Tester
{
	class Program
	{
		static void Main(string[] args)
		{
			Pokémon userPokemon = new Pokémon();
			Console.WriteLine("Geef de naam van de Pokémon:");
			userPokemon.Name = Console.ReadLine();
			Console.WriteLine("Geef de nummer van de Pokémon:");
			userPokemon.Number = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Geef de type van de Pokémon:");
			userPokemon.Type = Console.ReadLine();
			Console.WriteLine("Geef de hp van de Pokémon:");
			userPokemon.HP_Base = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Geef de attack van de Pokémon:");
			userPokemon.Attack_Base = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Geef de defensie van de Pokémon:");
			userPokemon.Defense_Base = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Geef de speciale aanval van de Pokémon:");
			userPokemon.SpecialAttack_Base = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Geef de speciale defensie van de Pokémon:");
			userPokemon.SpecialDefense_Base = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Geef de snelheid van de Pokémon:");
			userPokemon.Speed_Base = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Geef de lvl nummer van de Pokémon:");
			int levels = Convert.ToInt32(Console.ReadLine());

			for (int i = 1; i <= levels; i++)
			{
				userPokemon.IncreaseLevel();
			}

			userPokemon.ShowInfo();
			
		}
	}
}
