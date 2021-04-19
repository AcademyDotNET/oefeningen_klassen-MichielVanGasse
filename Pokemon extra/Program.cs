using System;

namespace Pokemon_deel2
{
	class Program
	{
		static void Main(string[] args)
		{
			Pokémon randomPokemon1;
			Pokémon randomPokemon2;

			randomPokemon1 = Pokémon.GeneratorPokemon();
			randomPokemon2 = Pokémon.GeneratorPokemon();
			

			Pokémon mewto = new Pokémon(45, 42, 50, 65, 34, 67);
			Pokémon ditto = new Pokémon() { HP_Base = 40, Name = "Ditto" };

			mewto.ShowInfo();
			ditto.ShowInfo();

			Pokémon.NoLevelingAllowed = true;

			for (int i = 0; i < 10; i++)
			{
				randomPokemon1.ShowInfo();
				randomPokemon2.ShowInfo();
				int resultBattle = Pokémon.Battle(randomPokemon1, randomPokemon2);
				if (resultBattle == 1 && resultBattle != 0)
				{
					randomPokemon1.IncreaseLevel();
				}
				else if (resultBattle == 2 && resultBattle != 0)
				{
					randomPokemon2.IncreaseLevel();
				}
			}

			Pokémon.Info();
		}	
	}
}
