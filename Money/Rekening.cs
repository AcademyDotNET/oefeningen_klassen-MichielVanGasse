using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
	abstract class Rekening
	{
		private double saldo;

		public double Saldo 
		{
			get { return saldo; }
		}
		public void VoegGeldToe(double saldo)
		{
			this.saldo += saldo;
		}
		public void HaalGeldAf(double removeSaldo)
		{
			saldo -= removeSaldo;
		}
		public abstract double BerekenRente();
	}
}
