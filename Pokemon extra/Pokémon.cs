using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_deel2
{
	class Pokémon
	{
		public Pokémon()
		{
			baseHP = 10;
			baseAttack = 10;
			baseDefense = 10;
			baseSpecialAttack = 10;
			baseSpecialDefense = 10;
			baseSpeed = 10;
		}
		public Pokémon(int _baseHP,int _baseAttack, int _baseDefense, int _baseSpecialAttack, int _baseSpecialDefense, int _baseSpeed)
		{
			baseHP = _baseHP;
			baseAttack = _baseAttack;
			baseDefense = _baseDefense;
			baseSpecialAttack = _baseSpecialAttack;
			baseSpecialDefense = _baseSpecialDefense;
			baseSpeed = _baseSpeed;
		}
		

		int baseHP;
		int baseAttack;
		int baseDefense;
		int baseSpecialAttack;
		int baseSpecialDefense;
		int baseSpeed;
		int level = 1;
		static int verhoogLevel = 0;
		static int battles = 0;
		static int battleGelijk = 0;
		static int generatorPokemonTotal = 0;
		public static bool NoLevelingAllowed { get; set; } = false;
		
		public string Name { get; set; }
		public string Type { get; set; }
		public int Number { get; set; }
		public int Average
		{
			get
			{
				return (HP_Base + Attack_Base + Defense_Base + SpecialAttack_Base + SpecialDefense_Base + Speed_Base) / 6;
			}
		}
		public int Total
		{
			get
			{
				return HP_Base + Attack_Base + Defense_Base + SpecialAttack_Base + SpecialDefense_Base + Speed_Base;
			}
		}
		public int HP_Full
		{
			get
			{
				return (((HP_Base + 50) * Level) / 50) + 10;
			}
		}
		public int Level
		{
			get
			{
				return level;
			}
			private set
			{
				level = value;
			}
		}
		public int HP_Base
		{
			get
			{
				return baseHP;
			}
			set
			{
				baseHP = value;
			}
		}
		public int Attack_Base
		{
			get
			{
				return baseAttack;
			}
			set
			{
				baseAttack = value;
			}
		}
		public int Defense_Base
		{
			get
			{
				return baseDefense;
			}
			set
			{
				baseDefense = value;
			}
		}
		public int SpecialAttack_Base
		{
			get
			{
				return baseSpecialAttack;
			}
			set
			{
				baseSpecialAttack = value;
			}
		}
		public int SpecialDefense_Base
		{
			get
			{
				return baseSpecialDefense;
			}
			set
			{
				baseSpecialDefense = value;
			}
		}
		public int Speed_Base
		{
			get
			{
				return baseSpeed;
			}
			set
			{
				baseSpeed = value;
			}
		}
		public int HP_Base_Full
		{
			get
			{
				return ((HP_Base * Level) / 50) + 5;
			}
		}
		public int Attack_Base_Full
		{
			get
			{
				return ((Attack_Base * Level) / 50) + 5;
			}
		}
		public int Defense_Base_Full
		{
			get
			{
				return ((Defense_Base * Level) / 50) + 5;
			}
		}
		public int SpecialAttack_Base_Full
		{
			get
			{
				return ((SpecialAttack_Base * Level) / 50) + 5;
			}
		}
		public int SpecialDefense_Base_Full
		{
			get
			{
				return ((SpecialDefense_Base * Level) / 50) + 5;
			}
		}
		public int Speed_Base_Full
		{
			get
			{
				return ((Speed_Base * Level) / 50) + 5; ;
			}
		}
		public void IncreaseLevel()
		{
			if(!NoLevelingAllowed)
			{
				Level++;
				verhoogLevel++;
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"No leveling allowed\n");
				Console.ResetColor();
			}
			
		}
		public void ShowInfo()
		{
			Console.WriteLine($"{Name}(level {Level})\nBase stats:\n\t*Health = {HP_Base}\n\t*Attack = {Attack_Base}\n\t*Defense = {Defense_Base}\n\t*SpecialDefense = {SpecialDefense_Base}\n\t*Speed = {Speed_Base}");
			Console.WriteLine($"\nFull stats:\n\t*Health = {HP_Base_Full}\n\t*Attack = {SpecialAttack_Base_Full}\n\t*Defense = {Defense_Base_Full}\n\t*SpecialDefense = {SpecialDefense_Base_Full}\n\t*Speed = {Speed_Base_Full}");
			Console.WriteLine($"\nTotal stats:\n\t*Average = {Average}\n\t*Total = {Total}\n");
		}
		public static void Info()
		{
			Console.WriteLine($"Total stats:\n\tTotal generated Pokémon = {generatorPokemonTotal}\n\tTotal battles = {battles}\n\tTotal levels = {verhoogLevel}\n\tTotal gelijk = {battleGelijk}");
		}
		public static Pokémon GeneratorPokemon()
		{
			Pokémon randomPokemon = new Pokémon();
			Random rand = new Random();
			generatorPokemonTotal++;

			string[] names = new string[5] { "random1", "random2", "random3", "random4", "random5" };
			string[] type = new string[5] { "gras", "electric", "water", "zand", "steen" };

			randomPokemon.Name = names[rand.Next(0, 5)];
			randomPokemon.Number = rand.Next(1, 100);
			randomPokemon.Type = type[rand.Next(0, 5)];
			randomPokemon.HP_Base = rand.Next(1, 101);
			randomPokemon.Attack_Base = rand.Next(1, 101);
			randomPokemon.Defense_Base = rand.Next(1, 101);
			randomPokemon.SpecialAttack_Base = rand.Next(1, 101);
			randomPokemon.SpecialDefense_Base = rand.Next(1, 101);
			randomPokemon.Speed_Base = rand.Next(1, 101);

			return randomPokemon;
		}
		public static int Battle(Pokémon poke1, Pokémon poke2)
		{
			battles++;

			if (poke1 == null && poke2 == null)
			{
				return 0;
			}
			else if (poke1 == null)
			{
				return 1;
			}
			else if (poke2 == null)
			{
				return 2;
			}

			if (poke1.Average == poke2.Average)
			{
				battleGelijk++;
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
	}
}
