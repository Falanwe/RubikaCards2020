using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards
{
    public class Card : IComparable<Card>
    {
        public enum CardColor
        {
            None = -1,
            Clubs = 1,
            Diamonds = 2,
            Hearts = 3,
            Spades = 4
        }

        public enum CardValue
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

        /// <summary>
        /// characteristics of the card
        /// </summary>
        /// <remarks>Too many flags for the sake of demonstration</remarks>
        [Flags]
        public enum CardType
        {
            Red = 0x1,
            Black = 0x2,
            Heads = 0x4,
            Number = 0x8
        }

        public CardColor Color { get; private set; }
        public CardValue Value { get; private set; }
        public bool IsNullCard                                                                      //Util?
        {
            get
            {
                return (Color == CardColor.None || Value == CardValue.None);
            }
        }

        public CardType Type
        {
            get
            {
                var isRed = (Color == CardColor.Diamonds) || (Color == CardColor.Hearts);
                var isHead = (Value >= CardValue.Jack) && (Value < CardValue.Ace);

                return (isRed ? CardType.Red : CardType.Black) | (isHead ? CardType.Heads : CardType.Number);
            }
        }

        public Card(CardColor cardColor, CardValue cardValue)
        {
            Color = cardColor;
            Value = cardValue;
        }

        public Card(Random randomGenerator)
        {

            Color = (CardColor)randomGenerator.Next(1, 5);
            Value = (CardValue)randomGenerator.Next(2, 15);
        }

        public override string ToString()
        {
            return Value.ToString() + " of " + Color.ToString();
        }

        public int CompareTo(Card other)
        {
            if ((int)Value == (int)other.Value)
            {
                return (int)Color - (int)other.Color;
            }
            else
                return (int)Value - (int)other.Value;
        }
    }
}
