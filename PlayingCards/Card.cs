using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCards
{
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


        public CardColor Color { get; set; }
        public CardValue Value { get; set; }

        public CardType Type
        {
            get
            {
                var isRed = (Color == CardColor.Diamonds) || (Color == CardColor.Hearts);
                var isHead = Value >= CardValue.Jack;

                return (isRed ? CardType.Red : CardType.Black) | (isHead ? CardType.Head : CardType.Number);
            }
        }

        public int CompareTo(Card secondCard)
        {
            if(secondCard.Value > Value)
            {
                return 1;
            }
            else if(secondCard.Value < Value)
            {
                return -1;
            }
            else
            {
                if(secondCard.Color > Color)
                {
                    return 1;
                }
                else if(secondCard.Color < Color)
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
