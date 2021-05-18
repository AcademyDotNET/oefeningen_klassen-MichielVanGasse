using System;

namespace Sport_simulator
{
	class Program
	{
		static void Main(string[] args)
		{
			IRandom rand = new Randomizer();
			IOutput consoleOutput = new ConsoleOutput();
			Wedstrijd wedstrijd = new Wedstrijd(consoleOutput, rand);
		}
	}
}
