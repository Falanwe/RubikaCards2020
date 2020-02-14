using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCards
{
<<<<<<< HEAD
    [Flags]
    public enum CardColor
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    [Flags]
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

    [Flags]
    public enum CardType
    {
        Red = 0x1,
        Black = 0x2,
        Head = 0x4,
        Number = 0x8
    }

    public class Card : IComparable<Card>
    {


=======
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

    public class Card : IComparable<Card>
    {
>>>>>>> cfa05a79c4582612be373748db255b3ccc5982f8
        public CardColor Color { get; set; }
        public CardValue Value { get; set; }

        public CardType Type
        {
            get
            {
                var isRed = (Color == CardColor.Diamonds) || (Color == CardColor.Hearts);
                var isHead = Value >= CardValue.Jack;

<<<<<<< HEAD
                return (isRed ? CardType.Red : CardType.Black) | (isHead ? CardType.Head : CardType.Number);
=======
                return (isRed ? CardType.Red : CardType.Black) | (isHead ? CardType.Heads : CardType.Number);
>>>>>>> cfa05a79c4582612be373748db255b3ccc5982f8
            }
        }

        public int CompareTo(Card secondCard)
        {
<<<<<<< HEAD
            if(secondCard.Value > Value)
            {
                return 1;
            }
            else if(secondCard.Value < Value)
=======
            if (secondCard.Value > Value)
            {
                return 1;
            }
            else if (secondCard.Value < Value)
>>>>>>> cfa05a79c4582612be373748db255b3ccc5982f8
            {
                return -1;
            }
            else
            {
<<<<<<< HEAD
                if(secondCard.Color > Color)
                {
                    return 1;
                }
                else if(secondCard.Color < Color)
=======
                if (secondCard.Color > Color)
                {
                    return 1;
                }
                else if (secondCard.Color < Color)
>>>>>>> cfa05a79c4582612be373748db255b3ccc5982f8
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }

        }

        public override string ToString() => $"{Value} of {Color}";
    }
}
