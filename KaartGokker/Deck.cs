using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaartGokker
{
	class Deck
	{
		public Stack<Speelkaart> ShuffeldDeck { get; set; } = new Stack<Speelkaart>();
		List<Speelkaart> deck = new List<Speelkaart>();
		Random rand = new Random();
		public Deck()
		{
			for (int i = 1; i <= 13; i++)
			{
				deck.Add(new Speelkaart(i.ToString(), '♠', ConsoleColor.Black));
				deck.Add(new Speelkaart(i.ToString(), '♦', ConsoleColor.Red));
				deck.Add(new Speelkaart(i.ToString(), '♥', ConsoleColor.Red));
				deck.Add(new Speelkaart(i.ToString(), '♣', ConsoleColor.Black));
			}

			do
			{
				int shuffle = rand.Next(0, deck.Count);
				
				ShuffeldDeck.Push(deck[shuffle]);
				deck.RemoveAt(shuffle);

			} while (deck.Count != 0);
		}
	}
}
