using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
	class ProRekening : SpaarRekening
	{
		
		public override double BerekenRente()
		{
			return (10 * (int)(Saldo / 1000)) + base.BerekenRente();
		}
	}
}
