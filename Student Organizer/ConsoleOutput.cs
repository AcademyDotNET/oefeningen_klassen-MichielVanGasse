using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Organizer
{
	class ConsoleOutput : IOutput
	{
		public void Log(string message)
		{
			Console.WriteLine(message);
		}
	}
}
