using System;
using System.Collections.Generic;
using PlayingCards;

namespace PlayingCardsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var dealer = new CardDealer();
            dealer.Initialize();
            dealer.Shuffle();

            Card firstCard = dealer.DealOne();
            Card secondCard = dealer.DealOne();
            string compare = firstCard.CompareTo(secondCard);
            Console.WriteLine(compare);
        }
    }
}
