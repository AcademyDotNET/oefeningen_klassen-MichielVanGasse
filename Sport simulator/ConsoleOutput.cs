using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_simulator
{
	class ConsoleOutput : IOutput
	{
		public void Log(string message)
		{
			Console.WriteLine(message);
		}
	}
}
