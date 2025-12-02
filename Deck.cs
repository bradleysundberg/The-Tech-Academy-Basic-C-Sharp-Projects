using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        private List<Card> cards;
        private Random rng = new Random();

        public Deck()
        {
            cards = new List<Card>();
            CreateDeck();
            Shuffle();
        }

        private void CreateDeck()
        {
            // Assuming Suit and Face are enums matching the order of suits/ranks arrays
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            int[] values = { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };

            for (int s = 0; s < suits.Length; s++)
            {
                for (int r = 0; r < ranks.Length; r++)
                {
                    Card card = new Card
                    {
                        Suit = (Suit)s,
                        Face = (Face)r
                    };
                    cards.Add(card);
                }
            }
        }

        public void Shuffle()
        {
            int n = cards.Count;
            for (int i = n - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        public Card? DealCard()
        {
            if (cards.Count == 0)
                return null;

            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }
    }
}
