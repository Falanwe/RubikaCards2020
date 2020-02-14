using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCards
{
    public class Card : IComparable<Card>
    {
        public enum Color
        {
            Clubs,
            Diamonds,
            Hearts,
            Spades
        }

        public enum Value
        {
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Height = 8,
            Nine = 9,
            Ten = 10,
            V = 11,
            Q = 12,
            K = 13,
            As = 14
        }

        public Color color;
        public Value value;

        public List<Card> CompareCards(Card c1, Card c2)
        {
            List<Card> res = new List<Card>();

            if(c1.value != c2.value)
            {
                if(c1.value < c2.value)
                {
                    res.Add(c2);
                    res.Add(c1);
                }
                else if(c1.value > c2.value)
                {
                    res.Add(c1);
                    res.Add(c2);
                }
            }
            else if(c1.value == c2.value)
            {
                if(c1.color == c2.color)
                {
                    res.Add(c2);
                    res.Add(c1);
                    return res;
                }
                else if(c1.color < c2.color)
                {
                    res.Add(c2);
                    res.Add(c1);
                }
                else if(c1.color > c2.color)
                {
                    res.Add(c2);
                    res.Add(c1);
                }
            }

            return res;
        }

        public int CompareTo(Card other)
        {
            throw new NotImplementedException();
        }
    }
}
