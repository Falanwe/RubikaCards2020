using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCards
{
    public static class Fibonacci
    {
        public static long Fibo(int len)
        {
            long a = 0, b = 1, c = 0;
            for (int i = 1; i < len; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
    }
}
