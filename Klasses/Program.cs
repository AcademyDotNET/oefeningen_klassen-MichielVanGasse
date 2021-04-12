using System;

namespace Klasses
{
	class Program
	{
		static void Main(string[] args)
		{
			Auto auto = new Auto();

			for (int i = 0; i < 10; i++)
			{
				auto.RijKilometer();
			}
		}
	}
}
