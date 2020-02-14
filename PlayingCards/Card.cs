using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCards
{
    public enum Suit
    {
        Spade,
        Club,
        Diamond,
        Heart
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
}
