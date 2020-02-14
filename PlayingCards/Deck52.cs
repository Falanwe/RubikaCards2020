using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCards
{
    class Deck52 : IDeck
    {
        private List<Card> deck;

        public bool IsEmpty { get => (deck == null || deck.Count <= 0); }

        public Deck52()
        {
            deck = new List<Card>();
            Reset();
        }

        public void Shuffle(ICardShuffler shuffler)
        {
            shuffler.Shuffle(this);
        }

        public void AddCardAtTheBottom(Card card)
        {
            if(card != null)
                deck.Add(card);
        }

        public void AddCardOnTop(Card card)
        {
            if(card != null)
                deck.Insert(0, card);
        }

        public Card DrawCard()
        {
            if(!IsEmpty)
            {
                Card drawedCard = deck[0];
                deck.RemoveAt(0);
                return drawedCard;
            }
            else
            {
                return null;
            }
        }

        public void Reset()
        {
            deck.Clear();

            for(int color = 1; color < 5; color++)
            {
                for(int value = 2; value < 15; value ++)
                {
                    deck.Add(new Card((Card.CardColor)color, (Card.CardValue)value));
                }
            }
        }
    }
}
