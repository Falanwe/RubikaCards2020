using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace PlayingCardsConsole
{
    public class SimpleSort : ISort
    {
        public IEnumerable<T> Sort<T>(IEnumerable<T> source) where T : IComparable<T>
        {
            List<T> sortedList = CopyIEnumerable<T>(source);
            IEnumerator<T> enumerator = source.GetEnumerator();

            ListSort<T>(sortedList);

            return sortedList;
        }

        private List<T> CopyIEnumerable<T>(IEnumerable<T> source)
        {
            List<T> listCopy = new List<T>();
            
            foreach(T value in source)
            {
                listCopy.Add(value);
            }

            return listCopy;
        }

        private void ListSort<T>(List<T> source) where T : IComparable<T>
        {
            bool hasChange = false;

            do
            {
                hasChange = false;
                
                for(int i = 1; i < source.Count; i++)
                {
                    if (source[i].CompareTo(source[i-1]) < 0)
                    {
                        T tempValue = source[i];
                        source[i] = source[i - 1];
                        source[i - 1] = tempValue;
                        hasChange = true;
                    }
                }
            }
            while (hasChange);
        }
    }
}
