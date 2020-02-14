using System;
using System.Collections.Generic;

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

    public class CardDealer
    {
        private List<Card> cards = new List<Card>();
        
        public void Initialize()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int t = 0; t < 14; t++)
                {
                    Card card = new Card((Suit)i, t);
                    cards.Add(card);
                }
            }
        }

        public void Shuffle()
        {

        }

        public Card DealOne()
        {
            int index = 0;
            Card card = cards[index];
            cards.Remove(card);
            return card;
        }
    }

    public class Card
    {
        public Suit suit;
        public int rank;

        public Card(Suit suit, int rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        public string GetName()
        {
            return suit.ToString() + " " + rank;
        }

        public string CompareTo(Card otherCard)
        {
            string result = GetName() + " is";
            int rankA = rank;
            int rankB = otherCard.rank;
            if (rankA > rankB) result += " greater than ";
            else if (rankA < rankB) result += " less than ";
            else result += " equal to ";
            result += otherCard.GetName();
            return result;
        }
    }

    public enum Suit
    {
        Spade,
        Club,
        Diamond,
        Heart
    }
}
