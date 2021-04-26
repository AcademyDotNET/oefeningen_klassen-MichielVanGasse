using System;

namespace Moederbord
{
	class Program
	{
		static void Main(string[] args)
		{
			Moederbord Z390E_GAMING = new Moederbord();
			Z390E_GAMING.AGP.Add(new AGPSlot("GeForceRTX2080"));
			//Z390E_GAMING.CPU.Add(new CPUSlot("IntelCorei9_9900K"));
			Z390E_GAMING.RAM.Add(new RAMSlot("Corsair 8 GB DDR4-4000 module"));

			Z390E_GAMING.TestMoederbord();
		}
	}
}
