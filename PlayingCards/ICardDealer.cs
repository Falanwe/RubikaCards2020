using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCards
{
    interface ICardDealer
    {
        Card DealOne();
        void Shuffle();
        void TakeBackCard(Card card);
        void ResetGame();
    }
}
