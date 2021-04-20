using System;
using System.Diagnostics;

namespace test
{
	class Program
	{
		static void Main(string[] args)
		{
			Process.Start(@"c:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "vrt.be");
		}
	}
}
