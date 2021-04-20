using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speelkaarten
{
	enum Suite { Schoppen, Harten, Klaveren, Ruiten }
	class Speelkaart
	{
		string value;
		char symbol;
		string card;
		ConsoleColor color;

		public Speelkaart(string _value, char _symbol, ConsoleColor _color)
		{
			value = _value;
			CheckValue();
			symbol = _symbol;
			card = DrawCard();
			color = _color;
		}
		public ConsoleColor Color
		{
			get { return color; }
		}
		public void CheckValue()
		{
			switch (value)
			{
				case "11":
					value = "B";
					break;
				case "12":
					value = "D";
					break;
				case "13":
					value = "H";
					break;
				case "1":
					value = "A";
					break;
				default:
					break;
			}
		}
		public string DrawCard()
		{
			if (value == "10")
			{
				return $@"


		┌─────────┐
		│{value}       │
		│         │
		│         │
		│    {symbol}    │
		│         │
		│         │
		│       {value}│
		└─────────┘";

			}
			else
			{
				return $@"


		┌─────────┐
		│{value}        │
		│         │
		│         │
		│    {symbol}    │
		│         │
		│         │
		│        {value}│
		└─────────┘";
			}
		}
	}

}
