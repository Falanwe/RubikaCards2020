using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCardsConsole
{
    public static class Fibonacci
    {
        public static double Fibo(int n)
        {
            double a = 0;
            double b = 1;
            double result = 0;

            for (int i = 0; i < n; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }

            return a;
        }
    }
}
