using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ziekenhuis
{
	class Patient
	{
		protected double Kosten { get; set; }
		public string Naam { get; set; }
		public int UurZiekenhuis { get; set; }
		protected virtual void BerekenKost()
		{
			Kosten = 50 + (UurZiekenhuis * 20);
		}

		public void ToonInfo()
		{
			BerekenKost();
			Console.WriteLine($"{Naam}  {Kosten}");
		}
	}
}
