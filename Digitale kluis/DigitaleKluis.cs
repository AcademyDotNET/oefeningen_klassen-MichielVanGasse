using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitale_kluis
{
	class DigitaleKluis
	{
		int code; 
		static int guesses;
		public DigitaleKluis(int _code)
		{
			code = _code;
		}

		private bool canShowCode;

		public bool CanShowCode
		{
			get { return canShowCode; }
			set { canShowCode = value; }
		}


		public int CodeLevel
		{
			get
			{
				if (code / 1000 < 0)
				{
					return 0;
				}
				else
				{
					return code / 1000;
				}
			}
		}

		public int Code
		{
			get
			{
				if (CanShowCode)
				{
					return code;
				}
				else
				{
					return -666;
				}
			}
			private set { code = value; }
		}
		public bool TryCode(int _code)
		{
			guesses++;
			if (Code == -666)
			{
				Console.WriteLine("Cheater!");
				return false;
			}
			else if(_code == Code)
			{
				Console.WriteLine($"Correct code, you tried {guesses} times");
				return true;
			}
			else
			{
				Console.WriteLine($"Wrong code, your guesses get increased with 1");
				return false;
			}
		}
	}
}
