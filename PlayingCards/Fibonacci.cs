using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace PlayingCards
{
    public static class Fibonacci
    {
        public static BigInteger Fibo(int n)
        {
            if(n < 0)
            {
                throw new ArgumentException("Fibo is not defined for negative number");
            }

            BigInteger previous = 0;
            BigInteger current = 1;
            checked
            {
                for (int i = 1; i < n; i++)
                {
                    BigInteger next = previous + current;
                    previous = current;
                    current = next;
                }
            }
            return current;
        }
    }
}
