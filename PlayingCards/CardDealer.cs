using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCards
{
    public class CardDealer : ICardDealer
    {
        private IDeck deck;
        private ICardShuffler shuffler;

        public CardDealer()
        {
            deck = new Deck52();
            shuffler = new RandomPickShuffler(RngGod.instance.RandomGenerator);
        }

        public Card DealOne()
        {
            return deck.DrawCard();
        }

        public void Shuffle()
        {
            deck.Shuffle(shuffler);
        }

        public void TakeBackCard(Card card)
        {
            deck.AddCardAtTheBottom(card);
            deck.Shuffle(shuffler);
        }

        public void ResetGame()
        {
            deck.Reset();
            deck.Shuffle(shuffler);
        }
    }
}
