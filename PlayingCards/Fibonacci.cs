using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace PlayingCardsConsole
{
    public class Fibonacci
    {
        public static List<BigInteger> fibonacciNumbers;
        public static List<BigInteger> negativefibonacciNumbers;

        public static BigInteger Fibo(int n)
        {
            if(n>=0)
            {
                if (fibonacciNumbers == null)
                {
                    fibonacciNumbers = new List<BigInteger>();
                    fibonacciNumbers.Add(0);
                    fibonacciNumbers.Add(1);
                }

                if (n < fibonacciNumbers.Count)
                {
                    return fibonacciNumbers[n];
                }
                else
                {
                    for (int i = fibonacciNumbers.Count; i <= n; i++)
                    {
                        fibonacciNumbers.Add(fibonacciNumbers[i - 2] + fibonacciNumbers[i - 1]);
                    }
                    return fibonacciNumbers[n];
                }
            }
            else
            {
                if (negativefibonacciNumbers == null)
                {
                    negativefibonacciNumbers = new List<BigInteger>();
                    negativefibonacciNumbers.Add(1);
                    negativefibonacciNumbers.Add(0);
                }

                if (-n < negativefibonacciNumbers.Count - 1)
                {
                    return negativefibonacciNumbers[-n + 1];
                }
                else
                {
                    for (int i = negativefibonacciNumbers.Count; i <= -n + 1; i++)
                    {
                        negativefibonacciNumbers.Add(negativefibonacciNumbers[i - 2] - negativefibonacciNumbers[i - 1]);
                    }
                    return negativefibonacciNumbers[-n + 1];
                }
            }
        }

    }
}
