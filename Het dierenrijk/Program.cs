using System;
using System.Collections.Generic;

namespace Het_dierenrijk
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Animal> animals = new List<Animal>();
			Animal bear = new Animal();
			Animal tiger = new Animal();
			Animal horse = new Animal();
			Reptile crocodile = new Reptile();
			Mammal dolphin = new Mammal();

			animals.Add(bear);
			animals.Add(tiger);
			animals.Add(horse);
			animals.Add(crocodile);
			animals.Add(dolphin);

			foreach (var animal in animals)
			{
				animal.ToonInfo();
			}
		}
	}
}
