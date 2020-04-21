using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCardsConsole
{
    public class InsertingSort : ISort
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

            for(var insertingIndex = 0; insertingIndex<copy.Length; insertingIndex++)
            {
                for(var comparingIndex = insertingIndex +1; comparingIndex < copy.Length; comparingIndex++)
                {
                    if(copy[insertingIndex].CompareTo(copy[comparingIndex])>0)
                    {
                        Swap(insertingIndex, comparingIndex);
                    }
                }
            }

            return copy;
        }
    }
}
