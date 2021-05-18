using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_simulator
{
	interface IAthlete
	{
		public string SpelerNaam { get; set; }
		public void Attack();
		public void Stayeren();
		public void Details();
		public void StelIn(string _spelerNaam, int _rugNummer, bool _isVluchter, bool _isInLotto, Reeks _reeks);
	}
}
