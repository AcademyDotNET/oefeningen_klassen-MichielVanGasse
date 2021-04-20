using System;
using System.Collections.Generic;

namespace Student_Organizer
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Student> studenten = new List<Student>();
			for (int i = 0; i < 5; i++)
			{
				studenten.Add(new Student());
			}

			bool invalid = true;
			int student;

			do
			{
				bool edit = true;
				Console.WriteLine("1 voor studenten bewerken, 2 voor alle studenten weer te geven, 3 zoek een student bij naam");
				string choise = Console.ReadLine();
				if (choise == "1")
				{
					do
					{
						Console.WriteLine("Welke student wil je? Van 1 tot 5.");


						if (Int32.TryParse(Console.ReadLine(), out student))
						{
							if (student >= 1 && student <= 5)
							{
								student -= 1;
								if (studenten[student].Naam != null)
								{
									Console.WriteLine("Wil je de bestaande overschrijven? y/n");
									if(Console.ReadLine() == "y")
									{ 
										invalid = false;
									}
									else
									{
										invalid = false;
										edit = false;
									}
								}
								else
								{
									invalid = false;
								}
							}
						}

					} while (invalid);
					if(edit)
					{ 
					studenten[student].Klas = InputCheckEnum("Welke klas EA1,EA2,EA3 of EA4");
					Console.WriteLine("Geef de naam");
					studenten[student].Naam = Console.ReadLine();
					studenten[student].Leeftijd = InputCheckInt("Geef de leeftijd");
					studenten[student].PuntenCommunicatie = InputCheckInt("Geef de punten communicatie");
					studenten[student].PuntenProgrammingPrinciples = InputCheckInt("Geef de punten programming principles");
					studenten[student].PuntenWebTech = InputCheckInt("Geef de punten webtech");
					}
				}
				if (choise == "2")
				{
					foreach (var students in studenten)
					{
						if (students.Naam != null)
						{
							students.GeefOverzicht();
						}
					}
				}
				if (choise == "3")
				{
					Console.WriteLine("Geef de naam");
					string input = Console.ReadLine();
					foreach (var students in studenten)
					{
						if (students.Naam == input)
						{
							students.GeefOverzicht();
						}
					}
				}
			} while (true);
		}
		static Klassen InputCheckEnum(string question)
		{
			Klassen klas = new Klassen();
			bool invalid = true;

			do
			{
				Console.WriteLine(question);

				if (Enum.TryParse(Console.ReadLine(), out klas))
				{

					invalid = false;
				}

			} while (invalid);

			return klas;
		}
		static int InputCheckInt(string question)
		{
			int value = 0;
			bool invalid = true;
			do
			{
				Console.WriteLine(question);
				if (Int32.TryParse(Console.ReadLine(), out value))
				{
					invalid = false;
				}
			} while (invalid);
			return value;
		}
	}
}
