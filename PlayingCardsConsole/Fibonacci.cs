using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace PlayingCardsConsole
{
    public static class Fibonacci
    {
        private class FiboEnumerable : IEnumerable<BigInteger>
        {
            public IEnumerator<BigInteger> GetEnumerator()
            {
                return new FiboEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return new FiboEnumerator();
            }
        }

        private class FiboEnumerator : IEnumerator<BigInteger>
        {
            private int _index = -1;
            public BigInteger Current
            {
                get
                {
                    if (_index < 0)
                    {
                        throw new InvalidOperationException();
                    }
                    return Fibo(_index);
                }
            }
            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                _index++;
                return true;
            }

            public void Reset()
            {
                _index = -1;
            }
        }

        public static IEnumerable<BigInteger> Sequence()
        {
            BigInteger previous = 0;
            yield return previous;

            BigInteger current = 1;
            while(true)
            {
                yield return current;

                var next = previous + current;
                previous = current;
                current = next;
            }            
        }

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
            for (int i = 1; i < n; i++)
            {
                var next = previous + current;
                previous = current;
                current = next;
            }

            return current;
        }
    }


}
