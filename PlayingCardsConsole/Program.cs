using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using PlayingCards;


namespace PlayingCardsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var sort = new VeryGoodSort();
            var dealer = new CardDealer();
            var cards = dealer.DealInfinitely().Take(10000).ToList();

            foreach(var card in sort.Sort(cards))
            {
                Console.WriteLine(card);
            }

            Console.WriteLine($"it took me only {Card.ComparisonCount} comparisons!");

            Console.ReadLine();
        }
    }
}
