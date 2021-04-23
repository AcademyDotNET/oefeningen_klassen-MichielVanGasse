using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin
{
	abstract class Dier
	{
		public int Weight { get; set; }
		public Dier()
		{
			Weight = 3;
		}
		public abstract void Zegt();
	}
}
