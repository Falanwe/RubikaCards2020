using System;
using System.Collections.Generic;
using System.Text;
using PlayingCards;

namespace PlayingCardsConsole
{
    public class CardDealer
    {
        public enum CardType {Spades,Hearts,Diamonds,Clubs }
        private CardType myType;

        public CardType MyType { get => myType; set => myType = value; }

        public CardDealer()
        {
            Random rand = new Random();
            rand.Next(0, 4);
          //  MyType = rand;

        }

        public void Shuffle()
        {
        }

        public Card DealOne()
        {
            return new Card();
        }


    }
}
