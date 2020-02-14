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

            Console.WriteLine($"First card ({firstCard}) is {(firstCard.CompareTo(secondCard) > 0 ? "greater" : "smaller")} than second card ({secondCard}).");

            var type = firstCard.Type;
            Console.WriteLine($"{firstCard} is { (type.HasFlag(CardType.Red) ? "" : "not") } red");
            Console.WriteLine($"{firstCard} is { (type.HasFlag(CardType.Black) ? "" : "not") } black");
            Console.WriteLine($"{firstCard} is { (type.HasFlag(CardType.Head) ? "" : "not") } head");
            Console.WriteLine($"{firstCard} is { (type.HasFlag(CardType.Number) ? "" : "not") } number");

        }
    }
}
