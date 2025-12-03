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
            Card dealtCard = Deck.DealCard();
            Hand.Add(dealtCard);
            Console.WriteLine(dealtCard.ToString() + "\n");
        }
    }
}