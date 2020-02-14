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
                for (int t = 0; t < 13; t++)
                {
                    Card card = new Card((Suit)i, t);
                    cards.Add(card);
                }
            }
        }

        public void Display()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                Console.WriteLine(cards[i].GetName());
            }
        }

        public void Shuffle()
        {
            int count = cards.Count;
            List<Card> newCards = new List<Card>();
            for (int i = 0; i < count; i++)
            {
                Random rand = new Random();
                int index = rand.Next(0, cards.Count);
                Card card = cards[index];
                newCards.Add(card);
                cards.RemoveAt(index);
            }

            cards.Clear();
            for (int i = 0; i < newCards.Count; i++)
            {
                cards.Add(newCards[i]);
            }
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
