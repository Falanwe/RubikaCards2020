using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCardsConsole
{
    public class VeryGoodSort : ISort
    {
        public IEnumerable<T> Sort<T>(IEnumerable<T> source) where T : IComparable<T>
        {
            throw new NotImplementedException();
        }
    }
}
