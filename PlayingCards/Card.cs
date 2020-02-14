using System;

namespace PlayingCards
{


    public class Card : IComparable<Card>
    {

        CardColor myColor;
        CardValue myValue;
        public CardColor MyColor { get => myColor; set => myColor = value; }
        public CardValue MyValue { get => myValue; set => myValue = value; }

        public Card()
        {
            Random rand = new Random();
            MyColor = (CardColor)rand.Next(0, 4);
            Random rand2 = new Random();
            MyValue = (CardValue)rand2.Next(0, 14);
        }


        public int CompareTo(Card secondCard)
        {
            if (MyValue > secondCard.MyValue)
            {
                return 1;
            }
            else if (MyValue < secondCard.MyValue)
            {
                return -1;
            }

            if (MyColor > secondCard.MyColor)
            {
                return 1;
            }
            else if (MyColor < secondCard.MyColor)
            {
                return -1;
            }

            return 0;

            //   throw new NotImplementedException();
        }
    }
}

public enum CardColor { Spades, Diamonds, Hearts, Clubs }
public enum CardValue { Ace, Two, Three, Four, Five, Six, Seven, Heigh, Nine, Ten, Jack, Queen, King }