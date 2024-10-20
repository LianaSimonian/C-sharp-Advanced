using System.Collections.Generic;
using System;

namespace Generics
{
    public class GenericList<T>
    {
        private List<T> _items = new List<T>();
        public void Add(T value)
        {
            _items.Add(value);
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _items.Count)
                    throw new IndexOutOfRangeException("Index is out of range.");

                return _items[index];
            }
            set
            {
                if (index < 0 || index >= _items.Count)
                    throw new IndexOutOfRangeException("Index is out of range.");

                _items[index] = value;
            }
        }
    }
    }
