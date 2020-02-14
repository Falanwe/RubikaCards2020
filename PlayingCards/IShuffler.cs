using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCards
{
    interface ICardShuffler
    {
        void Shuffle(IDeck deck);
    }
}
