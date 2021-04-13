using System;

namespace BankManager
{
	class Program
	{
		static void Main(string[] args)
		{
			BankAccount rekening1 = new BankAccount();
			BankAccount rekening2 = new BankAccount();
			BankAccount rekening3 = new BankAccount();

			rekening1.Naamveld = "Jos";
			rekening2.Naamveld = "Jossefien";
			rekening3.Naamveld = "Jef";

			rekening1.Rekeningnummer = "BE 001";
			rekening2.Rekeningnummer = "BE 002";
			rekening3.Rekeningnummer = "BE 003";

			rekening1.PayInFunds(1000);
			rekening2.PayInFunds(1000);
			rekening3.PayInFunds(1000);

			rekening1.ChangeState(AccountState.Geldig);
			rekening2.ChangeState(AccountState.Geldig);
			rekening3.ChangeState(AccountState.Geblokkeerd);

			rekening2.PayInFunds(rekening1.WithdrawFunds(50, rekening2.MyAccountState));
			rekening1.GetBalance();
			rekening2.GetBalance();
			rekening3.PayInFunds(rekening2.WithdrawFunds(50, rekening3.MyAccountState));
			rekening3.GetBalance();
			rekening2.GetBalance();
			rekening1.PayInFunds(rekening2.WithdrawFunds(5000, rekening1.MyAccountState));
			rekening1.GetBalance();
			rekening2.GetBalance();


			/*Nieuwe klant aanmaken (max 10)
Status van bestaande klant tonen
Geld op een bepaald account zetten
Geld van een bepaald account afhalen
Geld tussen 2 accounts overschrijven*/
		}
	}
}
