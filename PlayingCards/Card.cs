using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCards
{
    public enum CardColor
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum CardValue
    {
        Two = 2,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
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

    public class Card : IComparable<Card> , IEquatable<Card>
    {
        public CardColor Color { get; set; }
        public CardValue Value { get; set; }

        public CardType Type
        {
            get
            {
                var isRed = (Color == CardColor.Diamonds) || (Color == CardColor.Hearts);
                var isHead = Value >= CardValue.Jack;

                return (isRed ? CardType.Red : CardType.Black) | (isHead ? CardType.Heads : CardType.Number);
            }
        }

        public int CompareTo(Card secondCard)
        {
            //var valueComparison = Value.CompareTo(secondCard.Value);
            //if (valueComparison !=0)
            //{
            //    return valueComparison;
            //}
            //else
            //{
            //    return Color.CompareTo(secondCard.Color);
            //}

            return (4 * (int)Value + (int)Color - (4 * (int)secondCard.Value + (int)secondCard.Color));
        }

        public bool Equals(Card other)
        {
            //throw new NotImplementedException();
        }

        public override string ToString() => $"{Value} of {Color}";

        public static bool operator <(Card first , Card second)
        {
            //if (first)
            //{

            //}
        }
    }
}
