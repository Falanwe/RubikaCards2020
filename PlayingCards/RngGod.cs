using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCards
{
    public class RngGod
    {
        public static RngGod instance;
        public Random RandomGenerator { get ; private set; }
        public RngGod(Random random)
        {
            instance = this;
            RandomGenerator = random;
        }
    }
}
