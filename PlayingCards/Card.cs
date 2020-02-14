using System;

namespace PlayingCards
{

    public class Card : IComparable<Card>
    {

        public CardColor MyColor { get; set; }
        public CardValue MyValue { get; set; }
        public CardType MyType
        {
            get
            {
                var isRed = (MyColor == CardColor.Diamonds)|| (MyColor == CardColor.Hearts);
                var isHead = (MyValue >= CardValue.Jack);

                // "|" permet d'additionner des bytes et donc de merge différentes valeurs de l'enum
                return (isRed ? CardType.Red : CardType.Balck) | (isHead ? CardType.Heads : CardType.Number);
            }
            
        }

        public Card()
        {
            Random rand = new Random();
            MyColor = (CardColor)rand.Next(0, 4);
            Random rand2 = new Random();
            MyValue = (CardValue)rand2.Next(2, 15);
        }


        public int CompareTo(Card secondCard)
        {
            if (MyValue > secondCard.MyValue)
            {
                return 1;
            }
            else if (MyValue < secondCard.MyValue)
            {
                return -1;
            }

            if (MyColor > secondCard.MyColor)
            {
                return 1;
            }
            else if (MyColor < secondCard.MyColor)
            {
                return -1;
            }

            return 0;

            //   throw new NotImplementedException();
        }
    }
    public enum CardColor { Spades, Diamonds, Hearts, Clubs }
    public enum CardValue { Two = 2, Three, Four, Five, Six, Seven, Heigh, Nine, Ten, Jack, Queen, King, Ace }
    [Flags]
    public enum CardType { Red = 1, Balck = 2, Heads = 4, Number = 8 }
    // 0x = hexadécimal  ,0x1 0x2 0x4 0x8 0x10 0x20
}
