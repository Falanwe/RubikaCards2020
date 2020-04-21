using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCardsConsole
{
    public class VeryBadSort : ISort
    {
        public IEnumerable<T> Sort<T>(IEnumerable<T> source) where T : IComparable<T>
        {
            return source;
        }
    }
}
