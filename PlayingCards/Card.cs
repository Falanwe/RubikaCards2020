using System;

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

    public class Card : IComparable<Card>, IEquatable<Card>
    {
        public Card(CardColor color, CardValue value)
        {
            Color = color;
            Value = value;
        }

        public CardColor Color { get; }
        public CardValue Value { get; }
        public CardType Type
        {
            get
            {
                var isRed = (Color == CardColor.Diamonds) || (Color == CardColor.Hearts);
                var isHead = Value >= CardValue.Jack;

                return (isRed ? CardType.Red : CardType.Black) | (isHead ? CardType.Heads : CardType.Number);
            }
        }

        public bool IsRed => (Color == CardColor.Diamonds) || (Color == CardColor.Hearts);
        public bool IsHead => Value >= CardValue.Jack;

        public int CompareTo(Card secondCard)
        {
            if (secondCard == null)
            {
                return 1;
            }

            var valueComparison = Value.CompareTo(secondCard.Value);
            if (valueComparison != 0)
            {
                return valueComparison;
            }
            else
            {
                return Color.CompareTo(secondCard.Color);
            }
        }
        public override string ToString() => $"{Value} of {Color}";
        public override int GetHashCode()
        {
            return 4 * (int)Value + (int)Color;
        }

        public bool Equals(Card other) => CompareTo(other) == 0;
        public override bool Equals(object obj)
        {
            var other = obj as Card;
            if (other != null)
            {
                return Equals(other);
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Card first, Card second) => object.ReferenceEquals(first, second) || (first?.Equals(second) ?? false);
        public static bool operator !=(Card first, Card second) => !(first == second);
        public static bool operator >(Card first, Card second)
        {
            if (first == null)
            {
                return false;
            }
            else
            {
                return first.CompareTo(second) > 0;
            }
        }
        public static bool operator <(Card first, Card second)
        {
            if (first == null)
            {
                return second != null;
            }
            else
            {
                return first.CompareTo(second) < 0;
            }
        }
        public static bool operator >=(Card first, Card second) => !(first < second);
        public static bool operator <=(Card first, Card second) => !(first > second);
    }
}
