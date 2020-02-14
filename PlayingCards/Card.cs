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
            string s = suit.ToString();
            string suffix = "of " + s;
            string baseName = rank + " " + suffix;

            switch (rank)
            {
                case 1:
                    baseName = "Ace " + suffix;
                    break;

                case 11:
                    baseName = "Jack " + suffix;
                    break;

                case 12:
                    baseName = "Queen " + suffix;
                    break;

                case 13:
                    baseName = "King " + suffix;
                    break;
            }

            return "The " + baseName;
        }

        public string CompareTo(Card otherCard)
        {
            string result = GetName() + " is";
            int rankA = ConvertRank(rank);
            int rankB = ConvertRank(otherCard.rank);

            if (rankA > rankB) result += " greater than ";
            else if (rankA < rankB) result += " less than ";
            else result += " equal to ";

            result += otherCard.GetName();
            return result;
        }

        public int ConvertRank(int rank)
        {
            if(rank == 1)
            {
                rank = 14;
            }

            return rank;
        }
    }
}
