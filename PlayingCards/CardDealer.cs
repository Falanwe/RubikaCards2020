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
            Card newCard = new Card();
            Random rand = new Random();
            newCard.Color = (CardColor)rand.Next(0, (int)CardColor.Spades + 1);
            newCard.Value = (CardValue)rand.Next(2, (int)CardValue.Ace + 1);

            return newCard;
        }


    }


}
