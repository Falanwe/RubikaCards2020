using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCards
{
    class RandomPickShuffler : ICardShuffler
    {
        private Random _random;

        public RandomPickShuffler(Random random)
        {
            _random = random;
        }

        public void Shuffle(IDeck deck)
        {
            List<Card> temporaryDeck = TransferDeck(deck);

            while (temporaryDeck.Count > 0)
            {
                int randomIndex = _random.Next(temporaryDeck.Count);
                Card selectedCard = temporaryDeck[randomIndex];
                temporaryDeck.RemoveAt(randomIndex);
                deck.AddCardOnTop(selectedCard);
            }
        }

        private List<Card> TransferDeck(IDeck deck)
        {
            List<Card> temporaryDeck = new List<Card>();

            Card drawedCard;
            while(!deck.IsEmpty)
            {
                drawedCard = deck.DrawCard();
                if (drawedCard != null)
                    temporaryDeck.Add(drawedCard);
            }

            return temporaryDeck;
        }
    }
}
