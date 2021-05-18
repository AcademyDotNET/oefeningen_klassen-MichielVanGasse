using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Organizer
{
	class OrganizeStudents
	{
		List<IStudent> studenten = new List<IStudent>();
		
		int student;
		IOutput output;
		IInput input;
		
		public OrganizeStudents(IOutput output, IInput input)
		{
			this.input = input;
			this.output = output;
			for (int i = 0; i < 5; i++)
			{
				studenten.Add(new Student());
			}
		}
		public void Update()
		{
			output.Log("1 voor studenten bewerken, 2 voor alle studenten weer te geven, 3 zoek een student bij naam");
			string choise = input.Input();

			if (choise == "1")
			{
				StudentBewerken();
			}
			if (choise == "2")
			{
				StudentenWeergeven();
			}
			if (choise == "3")
			{
				StudentZoeken();
			}
		}
		private void StudentZoeken()
		{
			output.Log("Geef de naam");
			string userInput = input.Input();
			foreach (var students in studenten)
			{
				if (students.Naam == userInput)
				{
					students.GeefOverzicht();
				}
			}
		}
		private void StudentenWeergeven()
		{
			foreach (var students in studenten)
			{
				if (students.Naam != null)
				{
					students.GeefOverzicht();
				}
			}
		}
		private void StudentBewerken()
		{
			bool invalid = true;
			bool edit = true;
			do
			{
				output.Log("Welke student wil je? Van 1 tot 5.");
				if (Int32.TryParse(input.Input(), out student))
				{
					if (student >= 1 && student <= 5)
					{
						student -= 1;
						if (studenten[student].Naam != null)
						{
							output.Log("Wil je de bestaande overschrijven? y/n");
							if (input.Input() == "y")
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
			if (edit)
			{
				BewerkStudent();
			}
		}
		private void BewerkStudent()
		{
			studenten[student].Klas = InputCheckEnum("Welke klas EA1,EA2,EA3 of EA4");
			output.Log("Geef de naam");
			studenten[student].Naam = input.Input();
			studenten[student].Leeftijd = InputCheckInt("Geef de leeftijd");
			studenten[student].PuntenCommunicatie = InputCheckInt("Geef de punten communicatie");
			studenten[student].PuntenProgrammingPrinciples = InputCheckInt("Geef de punten programming principles");
			studenten[student].PuntenWebTech = InputCheckInt("Geef de punten webtech");
		}
		private Klassen InputCheckEnum(string question)
		{
			Klassen klas = new Klassen();
			do
			{
				Console.WriteLine(question);
			} while (Enum.TryParse(input.Input(), out klas));

			return klas;
		}
		private int InputCheckInt(string question)
		{
			int value = 0;
			do
			{
				output.Log(question);
			} while (Int32.TryParse(input.Input(), out value));
			return value;
		}
	}
}
