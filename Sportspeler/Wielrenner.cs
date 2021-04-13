using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportspeler
{
	enum Reeks { Pro, Amateur}
	class Wielrenner
	{
		private string spelerNaam = "Thomas De Gent";
		private int rugNummer = 69;
		private bool isVluchter = true;
		private bool isInLotto = true;
		private Reeks reeks;

		public void Attack()
		{
			Console.WriteLine($"{spelerNaam} is aan het aanvallen!");
		}
		public void Stayeren()
		{
			Console.WriteLine($"{spelerNaam} zit in het wiel.");
		}
		public void Details()
		{
			if(isInLotto)
			{ 
				Console.WriteLine($"{spelerNaam} met het nummer {rugNummer} rijd al een tijde bij LottoSudal.");
			}
			else
			{
				Console.WriteLine($"{spelerNaam} met het nummer {rugNummer}.");
			}
		}
		public void StelIn(string _spelerNaam, int _rugNummer, bool _isVluchter, bool _isInLotto, Reeks _reeks)
		{
			spelerNaam = _spelerNaam;
			rugNummer = _rugNummer;
			isVluchter = _isVluchter;
			isInLotto = _isInLotto;
			reeks = _reeks;
		}
	}
}
