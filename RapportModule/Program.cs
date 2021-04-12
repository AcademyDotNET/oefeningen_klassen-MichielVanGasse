using System;

namespace RapportModule
{
	class Program
	{
		static void Main(string[] args)
		{
			Resultaat mijnpunten = new Resultaat();
			mijnpunten.Percentage = 65;
			mijnpunten.PrintGraad();
		}
	}
}
