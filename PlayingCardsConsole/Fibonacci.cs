using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCardsConsole
{
    public static class Fibonacci
    {
        public static BigInteger Fibo(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Fibo is not defined for negative numbers.", nameof(n));
            }

            if (n == 0)
            {
                return 0;
            }

            BigInteger previous = 0;
            BigInteger current = 1;
            checked
            {
                for (int i = 1; i < n; i++)
                {
                    var next = previous + current;
                    previous = current;
                    current = next;
                }
            }
            return current;
        }
    }
}
