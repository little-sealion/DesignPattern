using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.IIterator;

namespace DesignPattern.Iterator
{
    public class BrowseHistory<T>
    {
        private List<T> _urls = new(10);

        public void Push(T url)
        {
            _urls.Add(url);
        }

        public T Pop()
        {
            var lastItem = _urls.Last();
            _urls.RemoveAt(_urls.Count - 1);
            return lastItem;
        }

        public IIterator<T> CreateIterator()
        {
            return new ListIterator<T>(this);
        }
        public class ListIterator<T> : IIterator<T>
        {
            private readonly BrowseHistory<T> _history;
            private int _index = 0;
            public ListIterator(BrowseHistory<T> history)
            {
                _history = history;

            }
            public T Current()
            {
                return _history._urls.ElementAt(_index);
            }

            public bool HasNext()
            {
                return _index < _history._urls.Count;
            }

            public void Next()
            {
                _index++;
            }
        }
    }
}