using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCardsConsole
{
    public class BubleSort : ISort
    {
        public IEnumerable<T> Sort<T>(IEnumerable<T> source) where T : IComparable<T>
        {
            var copy = source.ToArray();

            void Swap(int i, int j)
            {
                var temp = copy[i];
                copy[i] = copy[j];
                copy[j] = temp;
            }

            for (var end = copy.Length - 1; end > 1;)
            {
                var lastswap = 0;
                for (var i = 0; i < end; i++)
                {
                    if (copy[i].CompareTo(copy[i + 1]) > 0)
                    {
                        Swap(i, i + 1);
                        lastswap = i;
                    }
                }
                end = lastswap;
            }

            return copy;
        }
    }
}
