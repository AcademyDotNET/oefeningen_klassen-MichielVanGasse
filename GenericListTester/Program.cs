using System;
using System.Collections.Generic;
using static GenericListTester.Programma;

namespace GenericListTester
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> lijst = new List<int>();

			lijst.Add(5);
			lijst.Add(4);
			lijst.Add(3);

			Weergeven(lijst);
			VoegToe(lijst, 2);
			Verwijder(lijst,5);
			WeergevenPositie(lijst, 1);
			Weergeven(lijst);

			Student Jef = new Student("Jef");
			Student Flip = new Student("Flip");
			Student Flop = new Student("Flop");
			List<Student> studenten = new List<Student>();

			studenten.Add(Jef);
			studenten.Add(Flip);

			Weergeven(studenten);
			VoegToe(studenten, Flop);
			Verwijder(studenten, Jef);
			WeergevenPositie(studenten, 1);
			Weergeven(studenten);

		}
	}
}
/*
1) Maak een programma (klasse) dat voor elke mogelijke lijst van types kan gebruiken. 
Aan deze lijst willen we dan items kunnen toevoegen maar ook uit kunnen verwijderen (denk meerdere methodes) 

Ik wil ook een optie om de items in de lijst weer te geven, waarbij ik dan elk item ook individueel kan benaderen.

PT2: Maak dit mogelijk voor objecten. Stel dat ik een lijst v studenten heb wil ik voor
elke specifieke student in de lijst de waardes kunnen aanpassen. 
(ik selecteer een student en bewerk deze)*/