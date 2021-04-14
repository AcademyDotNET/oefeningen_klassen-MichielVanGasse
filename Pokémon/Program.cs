using System;

namespace Pokémon
{
	class Program
	{
		static void Main(string[] args)
		{
			Pokémon bulbasaur = new Pokémon();
			bulbasaur.Name = "Bulbasaur";
			bulbasaur.Number = 1;
			bulbasaur.Type = "grass";
			bulbasaur.HP_Base = 45;
			bulbasaur.Attack_Base = 49;
			bulbasaur.Defense_Base = 49;
			bulbasaur.SpecialAttack_Base = 65;
			bulbasaur.SpecialDefense_Base = 65;
			bulbasaur.Speed_Base = 45;

			bulbasaur.ShowInfo();

			for (int i = 1; i <= 100; i++)
			{
				bulbasaur.IncreaseLevel();
			}

			bulbasaur.ShowInfo();
		}
	}
}
