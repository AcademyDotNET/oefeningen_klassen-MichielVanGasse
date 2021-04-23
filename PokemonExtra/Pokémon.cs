using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonExtra
{
	class Pokémon
	{
		int baseHP;
		int baseAttack;
		int baseDefense;
		int baseSpecialAttack;
		int baseSpecialDefense;
		int baseSpeed;
		int level = 1;
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
			Level++;
		}
		public void ShowInfo()
		{
			Console.WriteLine($"{Name}(level {Level})\nBase stats:\n\t*Health = {HP_Base}\n\t*Attack = {Attack_Base}\n\t*Defense = {Defense_Base}\n\t*SpecialDefense = {SpecialDefense_Base}\n\t*Speed = {Speed_Base}");
			Console.WriteLine($"\nFull stats:\n\t*Health = {HP_Base_Full}\n\t*Attack = {SpecialAttack_Base_Full}\n\t*Defense = {Defense_Base_Full}\n\t*SpecialDefense = {SpecialDefense_Base_Full}\n\t*Speed = {Speed_Base_Full}");
			Console.WriteLine($"\nTotal stats:\n\t*Average = {Average}\n\t*Total = {Total}\n");
		}
		public override string ToString()
		{
			return $"\nFull stats:\n\t*Health = {HP_Base_Full}\n\t*Attack = {SpecialAttack_Base_Full}\n\t*Defense = {Defense_Base_Full}\n\t*SpecialDefense = {SpecialDefense_Base_Full}\n\t*Speed = {Speed_Base_Full}";
		}
		public static Pokémon GeneratorPokemon()
		{
			Pokémon randomPokemon = new Pokémon();
			Random rand = new Random();
			//generatorPokemonTotal++;

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
	}
}
