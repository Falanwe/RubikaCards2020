using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCardsConsole
{
    public static class Fibonacci
    {
        public static int Fibo(int n)
        {
            switch (n)
            {
                case 0:
                    {
                        return 0;
                    }
                case 1:
                    {
                        return 1;
                    }
                default:
                    {
                        return Fibo(n - 1) + Fibo(n - 2);
                    }
            }
        }
    }
}
