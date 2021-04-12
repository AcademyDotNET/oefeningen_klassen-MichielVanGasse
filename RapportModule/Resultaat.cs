using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapportModule
{
	class Resultaat
	{
		public int Percentage { get; set; } = 0;
		public void PrintGraad()
		{
			if (Percentage < 50)
			{
				Console.WriteLine("niet geslaagd");
			}
			else if (Percentage >= 50 && Percentage <= 68)
			{
				Console.WriteLine("voldoende");
			}
			else if (Percentage > 68 && Percentage <= 75)
			{
				Console.WriteLine("onderscheiding");
			}
			else if (Percentage > 75 && Percentage <= 85)
			{
				Console.WriteLine("grote onderscheiding");
			}
			else
			{
				Console.WriteLine("grootste onderscheiding");
			}
		}
	}
}
