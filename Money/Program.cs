using System;

namespace Money
{
	class Program
	{
		static void Main(string[] args)
		{
			SpaarRekening spaarRekening = new SpaarRekening();
			ProRekening proRekening = new ProRekening();

			spaarRekening.VoegGeldToe(3500);
			proRekening.VoegGeldToe(3500);


			Console.WriteLine($"normale rente = {spaarRekening.BerekenRente()} pro rente = { proRekening.BerekenRente()}");
		}
	}
}
