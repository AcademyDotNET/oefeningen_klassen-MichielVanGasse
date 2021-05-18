﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_simulator
{
	enum Reeks { Pro, Amateur}
	class Wielrenner: IAthlete
	{
		//private string spelerNaam = "Thomas De Gent";
		private int rugNummer = 69;
		private bool isVluchter = true;
		private bool isInLotto = true;
		private Reeks reeks;
		public string SpelerNaam { get; set; } = "Thomas De Gent";
		public Wielrenner()
		{

		}
		public Wielrenner(string _spelerNaam, int _rugNummer, bool _isVluchter, bool _isInLotto, Reeks _reeks)
		{
			StelIn(_spelerNaam, _rugNummer, _isVluchter, _isInLotto, _reeks);
		}

		public void Attack()
		{
			Console.WriteLine($"{SpelerNaam} is aan het aanvallen!");
		}
		public void Stayeren()
		{
			Console.WriteLine($"{SpelerNaam} zit in het wiel.");
		}
		public void Details()
		{
			if(isInLotto)
			{ 
				Console.WriteLine($"{SpelerNaam} met het nummer {rugNummer} rijd al een tijde bij LottoSudal.");
			}
			else
			{
				Console.WriteLine($"{SpelerNaam} met het nummer {rugNummer}.");
			}
		}
		public void StelIn(string _spelerNaam, int _rugNummer, bool _isVluchter, bool _isInLotto, Reeks _reeks)
		{
			SpelerNaam = _spelerNaam;
			rugNummer = _rugNummer;
			isVluchter = _isVluchter;
			isInLotto = _isInLotto;
			reeks = _reeks;
		}
	}
}
