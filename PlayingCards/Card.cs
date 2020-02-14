using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCardsConsole
{
    public class Card : IComparable<Card>
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

        public CardColor color;
        public CardValue value;



        public int CompareTo(Card other)
        {
            if(other.value > value)
            {
                return 1;
            }
            else if(other.value < value)
            {
                return -1;
            }
            else
            {
                if(other.color > color)
                {
                    return 1;
                }
                else if(other.color < color)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }

        }
    }
}
