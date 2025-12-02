using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            // Use Deck.DealCard() instead of accessing Deck.Cards directly
            Card dealtCard = Deck.DealCard();
            Hand.Add(dealtCard);
            Console.WriteLine(dealtCard.ToString() + "\n");
        }
    }
}

namespace ConsoleApp32
{
    // Assuming Dealer is a base class for TwentyOneDealer.
    public class Dealer
    {
        // Add any shared properties or methods for dealers here.
    }
}