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

        public static long Fibonana(long n)
        {
            long a = 0;
            long b = 1;
            long result = 0;

            long repeated = 0;

            while (repeated < (n - 1))
            {
                result = (a + b);

                a = b;
                b = result;

                repeated++;
            }

            return result;
        }
    }
}
