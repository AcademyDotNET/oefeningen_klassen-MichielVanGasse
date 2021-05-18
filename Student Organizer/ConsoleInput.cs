using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Organizer
{
	class ConsoleInput: IInput
	{
		public string Input()
		{
			return Console.ReadLine();
		}
	}
}
