using System;

namespace Prijzen_met_foreach
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] prijzen = new double[20];
			double gemiddelde = 0;
			prijzen = userInput();

			Console.Clear();
			foreach (double prijs in prijzen)
			{
				if (prijs >= 5)
				{
					Console.WriteLine(prijs);
				}
				gemiddelde += prijs;
			}
			Console.WriteLine(gemiddelde/prijzen.Length);
		}

		public static double [] userInput()
		{
			string input;
			bool correctInput;
			double [] requestList;

			do
			{
				correctInput = true;

				Console.WriteLine("Geef 20 prijzen na elkaar. vb 20 21 23");
				input = Console.ReadLine();

				string[] inputSplit = input.Split(' ');

				requestList = new double[inputSplit.Length];
				input = "";

				for (int i = 0; i < inputSplit.Length; i++)
				{
					input += inputSplit[i] + " ";

					if (!(double.TryParse(inputSplit[i], out requestList[i])) && inputSplit.Length != 20)
					{
						correctInput = false;
					}
				}

			} while (!correctInput);

			return requestList;
		}
	}
}
