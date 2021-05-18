using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Organizer
{
	interface IStudent
	{
		public Klassen Klas { get; set; }
		public string Naam { get; set; }
		public int Leeftijd { get; set; }
		public int PuntenCommunicatie { get; set; }
		public int PuntenProgrammingPrinciples { get; set; }
		public int PuntenWebTech { get; set; }
		public void GeefOverzicht();
		public double BerekenTotaalCijfer();
	}
}
