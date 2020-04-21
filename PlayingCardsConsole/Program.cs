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
            ISort sort = new InsertingSort();
            var dealer = new CardDealer();
            var cards = dealer.DealInfinitely().Take(10000).ToList();

            Card.ResetComparisonCount();

            Card previous = null;
            foreach (var current in sort.Sort(cards))
            {
                //Console.WriteLine(current);
                if (!object.ReferenceEquals(previous, null) && previous > current)
                {
                    Console.WriteLine($"{previous} is stricly greater than {current} ! Bad sorting!");
                    break;
                }
                previous = current;
            }

            Console.WriteLine($"it took me only {Card.ComparisonCount} comparisons!");

            Console.ReadLine();
        }
    }
}
