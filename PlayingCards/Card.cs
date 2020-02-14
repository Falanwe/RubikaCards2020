using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards
{
    public class Card : IComparable<Card>
    {
        public enum CardColorType
        {
            None = -1,
            Clubs = 1,
            Diamonds = 2,
            Hearts = 3,
            Spades = 4
        }

        public enum CardValueType
        {
            None = -1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Height = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13,
            Ace = 14
        }

        public CardColorType CardColor { get; private set; }
        public CardValueType CardValue { get; private set; }
        public bool IsNullCard                                                                      //Util?
        {
            get
            {
                return (CardColor == CardColorType.None || CardValue == CardValueType.None);
            }
        } 

        public Card(CardColorType cardColor, CardValueType cardValue)
        {
            CardColor = cardColor;
            CardValue = cardValue;
        }

        public Card(Random randomGenerator)
        {
            
            CardColor = (CardColorType)randomGenerator.Next(1, 5);
            CardValue = (CardValueType)randomGenerator.Next(2, 15);
        }

        public override string ToString()
        {
            return CardValue.ToString() + " of " + CardColor.ToString();
        }

        public int CompareTo(Card other)
        {
            if ((int)CardValue - (int)other.CardValue == 0)
            {
                return (int)CardColor - (int)other.CardColor;
            }
            else
                return (int)CardValue - (int)other.CardValue;
        }
    }
}
