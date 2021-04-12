using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasses
{
	public class Auto
	{
		private int aantalKilometers = 0;
		public Auto()
		{

		}
		public void RijKilometer()
		{
			aantalKilometers++;
			GeefKilometersWeer(aantalKilometers);
		}
		public void GeefKilometersWeer(int aantalKilometers)
		{
			Console.WriteLine($"Kilometers = {aantalKilometers}");
		}
	}
}
