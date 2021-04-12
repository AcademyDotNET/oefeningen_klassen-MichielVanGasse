using System;

namespace Studentklasse
{
	class Program
	{
		static void Main(string[] args)
		{
			Student student1 = new Student();
			student1.Klas = Klassen.EA2;
			student1.Leeftijd = 21;
			student1.Naam = "Joske Vermeulen";
			student1.PuntenCommunicatie = 12;
			student1.PuntenProgrammingPrinciples = 15;
			student1.PuntenWebTech = 13;

			student1.GeefOverzicht();
		}
	}
}
