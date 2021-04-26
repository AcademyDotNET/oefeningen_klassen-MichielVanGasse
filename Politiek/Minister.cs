using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politiek
{
	class Minister
	{
		public string Naam { get; set; }
		public override string ToString()
		{
			return $"{Naam} is de minister";
		}
	}
}
