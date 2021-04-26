using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politiek
{
	class Land
	{
		private President president = null;
		private EersteMinister eersteMinister = null;
		private List<Minister> ministers = new List<Minister>();

		public void MaakRegering(President presidentIn, List<Minister> ministersIn)
		{
			if (president == null)
			{
				president = presidentIn;
				if (ministersIn.Count > 0 && ministersIn.Count <= 5)
				{
					eersteMinister = new EersteMinister();
					eersteMinister.Naam = ministersIn[1].Naam;
					ministers = ministersIn;
				}
				else
				{
					Console.WriteLine("Regering is er al.");
				}
			}
		}
		public void JaarVerder()
		{
			if (president != null)
			{
				president.JaarVerder();
				if (president.Teller == 0)
				{
					president = null;
					eersteMinister = null;
					ministers.Clear();
				}
			}
		}
		public override string ToString()
		{
			if (president != null)
			{
				string ministersString = "";

				for (int i = 0; i < ministers.Count - 1; i++)
				{
					ministersString += ministers[i] + "\n";
				}
				return $"{president}\n{eersteMinister}\n{ministersString}";
			}
			else
			{
				return "Geen regering.";
			}
		}
	}
}

