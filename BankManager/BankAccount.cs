using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManager
{
	enum AccountState { Geldig, Geblokkeerd }
	class BankAccount
	{
		private double bedrag;

		public AccountState MyAccountState { get; set;}
		public string Naamveld { get; set; }
		public string Rekeningnummer { get; set; }

		public void ChangeState(AccountState accountState)
		{
			MyAccountState = accountState;
		}
		public int WithdrawFunds(double payment, AccountState accountState)
		{
			if(MyAccountState == AccountState.Geblokkeerd)
			{
				Console.WriteLine($"{Naamveld} is geblokkeerd.");
				return 0;
			}
			if (accountState == AccountState.Geblokkeerd)
			{
				Console.WriteLine($"Te storten rekening is geblokkeerd.");
				return 0;
			}
			if (payment <= 0)
			{
				payment = -payment;
			}

			if (payment <= bedrag)
			{
				bedrag -= (int)Math.Round(payment, 0);
				return (int)Math.Round(payment, 0);
			}
			else
			{
				Console.WriteLine($"Niet al het geld kon worden gegeven, maar {bedrag}, dus {Naamveld} komt {payment - bedrag} tekort");
				int onvolledigBedrag = (int)Math.Round(bedrag, 0);
				bedrag = 0;
				return onvolledigBedrag;
			}
		}
		public void PayInFunds(double income)
		{
			if (MyAccountState == AccountState.Geblokkeerd)
			{
				Console.WriteLine($"{Naamveld} is geblokkeerd.");
			}
			else if (income >= 0)
			{
				bedrag += (int)Math.Round(income, 0);
			}
		}
		public void GetBalance()
		{
			Console.WriteLine($"{Naamveld} balance is {bedrag}");
		}
	}
}
