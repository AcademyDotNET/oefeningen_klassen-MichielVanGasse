using System;

namespace Meetlat_constructor
{
	class Program
	{
		static void Main(string[] args)
		{
			Meetlat mijnLat = new Meetlat(2);
			Console.WriteLine($"{mijnLat.LengteInM} meter is {mijnLat.LengteInVoet} voet.");
		}
	}
}
