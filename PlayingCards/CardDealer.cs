using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCards
{
    public class CardDealer
    {
        private Random _rand = new Random();

        public void Shuffle()
        {

        }        

        public Card DealOne()
        {
            return new Card(
                (CardColor)_rand.Next(0, (int)CardColor.Spades + 1),
                (CardValue)_rand.Next(2, (int)CardValue.Ace + 1)
            );
        }

        public IEnumerable<Card> DealInfinitely()
        {
            while(true)
            {
                yield return DealOne();
            }
        }
    }
}
