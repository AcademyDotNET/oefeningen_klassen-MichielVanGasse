using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moederbord
{
	class Moederbord

	{
		public List<CPUSlot> CPU { get; set; } = new List<CPUSlot>();
		public List<RAMSlot> RAM { get; set; } = new List<RAMSlot>();
		public List<AGPSlot> AGP { get; set; } = new List<AGPSlot>();
		public void TestMoederbord()
		{
			if(AGP.Count == 0)
			{
				Console.WriteLine("Missing AGP");
			}
			if (RAM.Count == 0)
			{
				Console.WriteLine("Missing RAM");
			}
			if (CPU.Count == 0)
			{
				Console.WriteLine("Missing CPU");
			}
			if (AGP.Count != 0 && RAM.Count != 0 && CPU.Count != 0)
			{
				Console.WriteLine("PC is working");
			}
		}
	}
}
