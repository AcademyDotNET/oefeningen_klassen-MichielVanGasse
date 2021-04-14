using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokémon
{
	class Pokémon
	{
		int baseHP;
		int baseAttack;
		int baseDefense;
		int baseSpecialAttack;
		int baseSpecialDefense;
		int baseSpeed;
		int level;
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
		}
	}
}
