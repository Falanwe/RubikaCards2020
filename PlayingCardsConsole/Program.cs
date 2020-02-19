using System;
using PlayingCards;
using System.Collections.Generic;



namespace PlayingCardsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var dealer = new CardDealer();

            dealer.Shuffle();

            //var firstCard = dealer.DealOne();
            //var secondCard = dealer.DealOne();

            //Console.WriteLine($"First card ({firstCard}) is {(firstCard > secondCard ? "greater" : "smaller")} than second card ({secondCard}).");

            Dictionary<string, List<Card>> playerHands = new Dictionary<string, List<Card>>();

            playerHands.Add("Alexis", new List<Card>
            {
                new Card(CardColor.Hearts, CardValue.Seven),
                new Card(CardColor.Clubs, CardValue.King)
            });

            Console.Write(Fibonacci.Fibo(80).ToString("NO"));
        }
    }
}
