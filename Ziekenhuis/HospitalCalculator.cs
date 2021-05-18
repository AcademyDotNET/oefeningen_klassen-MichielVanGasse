using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ziekenhuis
{
	class HospitalCalculator
	{
		IPatient patient1 = new Patient();
		IPatient patient2 = new VerzekerdePatient();
		public HospitalCalculator()
		{
			patient1.Naam = "jos";
			patient1.UurZiekenhuis = 10;
			patient2.Naam = "fien";
			patient2.UurZiekenhuis = 10;
		}

		public void ShowCalulation()
		{
			patient1.ToonInfo();
			patient2.ToonInfo();
		}
	}
}
