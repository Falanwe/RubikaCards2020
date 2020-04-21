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
            ISort sort = new VeryBadSort();
            var dealer = new CardDealer();
            var cards = dealer.DealInfinitely().Take(10000).ToList();

            Card.ResetComparisonCount();
            //foreach(var card in sort.Sort(cards))
            //{
            //    Console.WriteLine(card);
            //}

            var b = cards[0] < cards[1];

            Console.WriteLine($"it took me only {Card.ComparisonCount} comparisons!");

            Console.ReadLine();
        }
    }
}
