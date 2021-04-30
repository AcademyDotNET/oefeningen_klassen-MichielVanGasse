using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapmaker
{
	interface IComposite
	{
		void UpdateElements(Point offset);
	}
}
