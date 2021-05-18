using System;
using System.Collections.Generic;

namespace Student_Organizer
{
	class Program
	{
		static void Main(string[] args)
		{
			IOutput output = new ConsoleOutput();
			IInput input = new ConsoleInput();
			OrganizeStudents organizeStudents = new OrganizeStudents(output, input);
			do
			{
				organizeStudents.Update();
			} while (true);
		}
		
	}
}
