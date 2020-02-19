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

        public static long Fibo3(long max, long f1 = 0, long f2 = 1, int step = 2)
        {
            if (step >= max)
            {
                return f1 + f2;
            }
            return Fibo3(max, f2, f1 + f2, step + 1);
        }
    }
}
