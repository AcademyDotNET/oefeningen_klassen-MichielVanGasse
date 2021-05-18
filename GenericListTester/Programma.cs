using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListTester
{
	static class Programma
	{
		public static void VoegToe<T>(List<T> lijst, T item)
		{
			lijst.Add(item);
			Console.WriteLine($"{item.ToString()} is toegevoegd.");
		}
		public static void Verwijder<T>(List<T> lijst, T item)
		{
			if (lijst.Contains(item))
			{
				lijst.Remove(item);
				Console.WriteLine($"{item.ToString()} is verwijderd.");
			}
		}
		public static void WeergevenPositie<T>(List<T> lijst, int index)
		{
			Console.WriteLine(lijst[index]);
		}
		public static void Weergeven<T>(List<T> lijst)
		{
			foreach (var item in lijst)
			{
				Console.WriteLine(item);
			}
		}
	}
}
