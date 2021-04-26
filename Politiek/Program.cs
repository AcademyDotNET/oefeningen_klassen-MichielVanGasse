using System;
using System.Collections.Generic;

namespace Politiek
{
	class Program
	{
		static void Main(string[] args)
		{
			President bob = new President() { Naam = "bob" };
			List<Minister> ministers = new List<Minister>();
			ministers.Add(new Minister() { Naam = "Jeff" });
			ministers.Add(new Minister() { Naam = "Jos" });
			ministers.Add(new Minister() { Naam = "Jan" });
			Land america = new Land();

			america.MaakRegering(bob, ministers);
			america.JaarVerder();
			america.JaarVerder();
			america.JaarVerder();
			america.JaarVerder();

			Console.WriteLine(america);
		}
	}
}
