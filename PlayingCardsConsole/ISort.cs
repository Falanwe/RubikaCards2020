using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingCardsConsole
{
    public interface ISort
    {
        IEnumerable<T> Sort<T>(IEnumerable<T> source) where T : IComparable<T>;
    }
}
