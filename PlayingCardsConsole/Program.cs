using System;
using PlayingCards;
using System.Collections.Generic;
using System.Collections.Concurrent;

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
            //
            //Console.WriteLine($"First card ({firstCard}) is {(firstCard > secondCard ? "greater" : "smaller")} than second card ({secondCard}).");

            Dictionary<string, List<Card>> playerHands = new Dictionary<string, List<Card>>();

            playerHands.Add("Alexis", new List<Card>
            {
                new Card(CardColor.Spades, CardValue.Ace),
                new Card(CardColor.Diamonds, CardValue.Two)
            });

            playerHands.Add("François", new List<Card>
            {
                new Card(CardColor.Hearts, CardValue.Seven),
                new Card(CardColor.Clubs, CardValue.King)
            });

            /*foreach(var value in playerHands.Values)
            {
                foreach (var card in value)
                {
                    Console.WriteLine(card);
                }

            }*/

            #region Exactement la même chose que d'appeler un foreach
            /*var hand = playerHands["Alexis"];
            IEnumerator<Card> enumerator = null;
            try
            {
                enumerator = hand.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current);
                }
            }
            finally
            {
                enumerator.Dispose();
            }*/
            #endregion

            #region ConcurrentBag --> permet de modifier l'énumérable pendant son parcours 
            /*ConcurrentBag<Card> hand = new ConcurrentBag<Card>(playerHands["Alexis"]);

            foreach(var card in hand)
            {
                Console.WriteLine(card);
                hand.TryTake(out var newCard);
            }
            Console.WriteLine(hand.Count);*/
            #endregion

            for (int i = 0; i < 0; i++)
            {
                Console.WriteLine(Fibonacci.FiboList(i));
            }
            Console.WriteLine(Fibonacci.FiboList(100000));
        }
    }
}
