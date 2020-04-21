using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCardsConsole
{
    public class VeryGoodSort : ISort
    {
        public IEnumerable<T> Sort<T>(IEnumerable<T> source) where T : IComparable<T>
        {
            return source.OrderBy(t => t);
        }
    }
}
