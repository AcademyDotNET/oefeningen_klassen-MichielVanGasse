using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ziekenhuis
{
	
	class VerzekerdePatient : Patient
	{
		
		protected override void BerekenKost()
		{
			base.BerekenKost();
			Kosten *= 0.9;
		}
	}
}
