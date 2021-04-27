using System;
using System.Collections.Generic;

namespace Magic
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Card> deck = new List<Card>();

			deck.Add(new CreatureCard());
			deck.Add(new SpellCard());
		}
	}
}
