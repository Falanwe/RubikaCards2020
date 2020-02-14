using System;
using PlayingCards;

namespace PlayingCardsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var dealer = new CardDealer();

            dealer.Shuffle();

            var firstCard = dealer.DealOne();
            var secondCard = dealer.DealOne();

            Console.WriteLine($"First card ({firstCard.MyColor.ToString() +" "+ firstCard.MyValue.ToString()}) is {(firstCard.CompareTo(secondCard) > 0 ? "greater" : "smaller")} than second card ({secondCard.MyColor.ToString() +" "+ secondCard.MyValue.ToString()}).");
        }
    }
}
