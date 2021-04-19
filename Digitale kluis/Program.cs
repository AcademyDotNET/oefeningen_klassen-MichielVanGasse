using System;

namespace Digitale_kluis
{
	class Program
	{
		static void Main(string[] args)
		{
			DigitaleKluis kluis1 = new DigitaleKluis(2000);
			bool correct = false;
			kluis1.CanShowCode = true;
			do
			{
				correct = kluis1.TryCode(Convert.ToInt32(Console.ReadLine()));
			} while (!correct);	
		}
	}
}
