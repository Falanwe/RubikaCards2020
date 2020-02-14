using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCards
{
    public class CardDealer
    {
        private List<Card> cards = new List<Card>();

        public void Initialize()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int t = 0; t < 14; t++)
                {
                    Card card = new Card((Suit)i, t);
                    cards.Add(card);
                }
            }
        }

        public void Shuffle()
        {

        }

        public Card DealOne()
        {
            int index = 0;
            Card card = cards[index];
            cards.Remove(card);
            return card;
        }
    }

}
