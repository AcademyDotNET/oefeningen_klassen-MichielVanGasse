using System;

namespace Pokémon_battler
{
	class Program
	{
		static void Main(string[] args)
		{
			Pokémon randomPokemon1;
			Pokémon randomPokemon2;

			randomPokemon1 = GeneratorPokemon();
			randomPokemon2 = GeneratorPokemon();

			for (int i = 0; i < 10; i++)
			{ 
			randomPokemon1.ShowInfo();
			randomPokemon2.ShowInfo();
			
				if(Battle(randomPokemon1, randomPokemon2) == 1 && Battle(randomPokemon1, randomPokemon2) != 0)
				{
					randomPokemon1.IncreaseLevel();
				}
				else if(Battle(randomPokemon1, randomPokemon2) == 2 && Battle(randomPokemon1, randomPokemon2) !=0)
				{
					randomPokemon2.IncreaseLevel();
				}
			}
		}
		static int Battle(Pokémon poke1, Pokémon poke2)
		{
			if(poke1 == null && poke2 == null)
			{
				return 0;
			}
			else if(poke1 == null)
			{
				return 1;
			}
			else if(poke2 == null)
			{
				return 2;
			}

			if (poke1.Average == poke2.Average)
			{
				return 0;
			}
			else if (poke1.Average > poke2.Average)
			{
				return 1;
			}
			else
			{
				return 2;
			}
		}
		static Pokémon GeneratorPokemon()
		{
			Pokémon randomPokemon = new Pokémon();
			Random rand = new Random();

			string[] names = new string[5] {"random1", "random2", "random3", "random4", "random5" };
			string[] type = new string[5] { "gras", "electric", "water", "zand", "steen" };

			randomPokemon.Name = names[rand.Next(0, 5)];
			randomPokemon.Number = rand.Next(1,100);
			randomPokemon.Type = type[rand.Next(0, 5)];
			randomPokemon.HP_Base = rand.Next(1, 101); 
			randomPokemon.Attack_Base = rand.Next(1, 101);
			randomPokemon.Defense_Base = rand.Next(1, 101);
			randomPokemon.SpecialAttack_Base = rand.Next(1, 101);
			randomPokemon.SpecialDefense_Base = rand.Next(1, 101);
			randomPokemon.Speed_Base = rand.Next(1, 101);

			return randomPokemon;
		}
	}
}
