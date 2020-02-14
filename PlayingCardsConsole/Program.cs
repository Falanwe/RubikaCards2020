using System;
using PlayingCards;

namespace PlayingCardsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            RngGod rng = new RngGod(new Random());
            var dealer = new CardDealer();

            dealer.Shuffle();

            var firstCard = dealer.DealOne();
            var secondCard = dealer.DealOne();

            Console.WriteLine($"First card ({firstCard}) is {(firstCard.CompareTo(secondCard) > 0 ? "greater" : "smaller")} than second card ({secondCard}).");
        }
    }
}
