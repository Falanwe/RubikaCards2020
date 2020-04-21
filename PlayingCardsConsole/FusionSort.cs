using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Text.RegularExpressions;

namespace PlayingCardsConsole
{
    public class FusionSort : ISort
    {
        public IEnumerable<T> Sort<T>(IEnumerable<T> source) where T : IComparable<T>
        {
            if(!source.Skip(1).Any())
            {
                return source;
            }
            else
            {
                var split = Split(source);
                return Fusion(Sort(split.first), Sort(split.second));
            }
        }

        private (IEnumerable<T> first, IEnumerable<T> second) Split<T>(IEnumerable<T> s)
        {
            var elementsWithIndex = s.Select((e, i) => (element: e, index: i));
            var groups = elementsWithIndex.GroupBy(tuple => tuple.index % 2, tuple => tuple.element);

            return (groups.First(), groups.Last());
        }

        private IEnumerable<T> Fusion<T>(IEnumerable<T> first, IEnumerable<T> second) where T : IComparable<T>
        {
            var firstEnumerator = first.GetEnumerator();
            var secondEnumerator = second.GetEnumerator();

            if (!firstEnumerator.MoveNext())
            {
                secondEnumerator.MoveNext();
                foreach (var t in GetRemainingValues(secondEnumerator))
                {
                    yield return t;
                }
                yield break;
            }

            if (!secondEnumerator.MoveNext())
            {
                foreach (var t in GetRemainingValues(firstEnumerator))
                {
                    yield return t;
                }
                yield break;
            }

            while (true)
            {
                if (firstEnumerator.Current.CompareTo(secondEnumerator.Current) <= 0)
                {
                    yield return firstEnumerator.Current;
                    if (!firstEnumerator.MoveNext())
                    {
                        foreach (var t in GetRemainingValues(secondEnumerator))
                        {
                            yield return t;
                        }
                        yield break;
                    }
                }
                else
                {
                    yield return secondEnumerator.Current;
                    if (!secondEnumerator.MoveNext())
                    {
                        foreach (var t in GetRemainingValues(firstEnumerator))
                        {
                            yield return t;
                        }
                        yield break;
                    }
                }
            }

            IEnumerable<T> GetRemainingValues(IEnumerator<T> enumerator)
            {
                do
                {
                    yield return enumerator.Current;
                }
                while (enumerator.MoveNext());
            }
        }
    }
}
