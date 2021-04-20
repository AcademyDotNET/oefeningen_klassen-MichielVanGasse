using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Organizer
{
	public enum Klassen { EA1, EA2, EA3, EA4 }
	class Student
	{
		public Klassen Klas { get; set; }
		public string Naam { get; set; }
		public int Leeftijd { get; set; }
		public int PuntenCommunicatie { get; set; }
		public int PuntenProgrammingPrinciples { get; set; }
		public int PuntenWebTech { get; set; }

		public double BerekenTotaalCijfer()
		{
			double gemiddelde = 0.0;

			gemiddelde = Math.Round(((PuntenCommunicatie + PuntenProgrammingPrinciples + PuntenWebTech) / 3.0),1);

			return gemiddelde;
		}

		public void GeefOverzicht()
		{
			Console.WriteLine($"{Naam}, {Leeftijd}\nKlas: {Klas}\n\nCijferrapport:\n**********\nCommunicatie:             {PuntenCommunicatie}\nProgramming Principles:   {PuntenProgrammingPrinciples}\nWeb Technology:           {PuntenWebTech}\nGemiddelde: {BerekenTotaalCijfer()}");
		}
	}
}
