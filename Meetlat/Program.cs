using System;

namespace Meetlat
{
	class Program
	{
		static void Main(string[] args)
		{
			Meetlat mijnLat = new Meetlat();
			mijnLat.BeginLengte = 2;
			Console.WriteLine($"{mijnLat.LengteInM} meter is {mijnLat.LengteInVoet} voet.");
		}
	}
}
