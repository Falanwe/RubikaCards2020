using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCards
{
    public class CardDealer
    {
        public void Shuffle()
        {

        }


        public Card DealOne()
        {
            Random rand = new Random();
            return new Card(
                (CardColor)rand.Next(0, (int)CardColor.Spades + 1),
                (CardValue)rand.Next(2, (int)CardValue.Ace + 1)
            );
        }


    }


}
