using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCards
{
    interface IDeck
    {
        void Shuffle(ICardShuffler shuffler);
        void AddCardOnTop(Card card);
        void AddCardAtTheBottom(Card card);
        Card DrawCard();
        void Reset();
        bool IsEmpty { get; }
    }
}
