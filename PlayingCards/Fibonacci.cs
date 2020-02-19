using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCardsConsole
{
    public class Fibonacci
    {
        public static List<long> fibonacciNumbers;
        public static long Fibo(int n)
        {
            if(fibonacciNumbers == null)
            {
                fibonacciNumbers = new List<long>();
                fibonacciNumbers.Add(0);
                fibonacciNumbers.Add(1);
            }

            if(n <= fibonacciNumbers.Count)
            {
                return fibonacciNumbers[n];
            }
            else if(n>0)
            {
                for(int i = fibonacciNumbers.Count; i <= n; i++)
                {
                    fibonacciNumbers.Add(fibonacciNumbers[i - 2] + fibonacciNumbers[i - 1]);
                }
                return fibonacciNumbers[n];
            }
            return 0;

            //switch (n)
            //{
            //    case 0:
            //        {
            //            return 0;
            //        }
            //    case 1:
            //        {
            //            return 1;
            //        }
            //    default:
            //        {
            //            return Fibo(n - 1) + Fibo(n - 2);
            //        }
            //}
        }

    }
}
