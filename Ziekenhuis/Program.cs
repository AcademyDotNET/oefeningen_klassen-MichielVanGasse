using System;

namespace Ziekenhuis
{
	class Program
	{
		static void Main(string[] args)
		{
			Patient patient1 = new Patient();
			VerzekerdePatient patient2 = new VerzekerdePatient();
			patient1.Naam = "jos";
			patient1.UurZiekenhuis = 10;
			patient2.Naam = "fien";
			patient2.UurZiekenhuis = 10;

			patient1.ToonInfo();
			patient2.ToonInfo();
		}
	}
}
