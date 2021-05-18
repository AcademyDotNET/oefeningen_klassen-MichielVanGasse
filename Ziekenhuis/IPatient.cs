using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ziekenhuis
{
	interface IPatient
	{
		public double Kosten { get; set; }
		public string Naam { get; set; }
		public int UurZiekenhuis { get; set; }
		public abstract void BerekenKost();
		public void ToonInfo();
	}
}
