using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace PlayingCards
{
    public class Fibonacci
    {
        public static int FiboNaive(int n)
        {
            switch (n)
            {
                case (0):
                    return 1;
                case (1):
                    return 1;
                default:
                    return FiboNaive(n-2) + FiboNaive(n-1);
            }
        }

        public static BigInteger FiboList(int n)
        {
            //List<BigInteger> values = new List<BigInteger> { 0, 1 };
            //for (int i = 2; i <= n; i++)
            //{
            //    values.Add(values[i - 1] + values[i - 2]);
            //}
            //return values[n];
            BigInteger downValue = 0;
            BigInteger upValue = 1;
            BigInteger stock = 0;

            for (int i = 2; i <= n; i++)
            {
                stock = upValue;
                upValue = downValue + upValue;
                downValue = stock;
                //values.Add(values[i - 1] + values[i - 2]);
            }

            return n == 0 ? downValue : upValue;
        }
    }
}
