using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCardsConsole
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
            newCard.color = (Card.CardColor)rand.Next(0, 4);
            newCard.value = (Card.CardValue)rand.Next(2, 16);

            return newCard;
        }


    }


}
