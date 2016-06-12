using System;
using System.Collections.Generic;

namespace HW15
{
    class DoubleLinkedList <T>
    {
        Element<T> _current;
        Element<T> _first;
        int _size;

        public void Add(T item)
        {
            Element<T> newElement = new Element<T>(item);
            _current = _first;
            if (_current == null)
            {
                _current = newElement;
                _first = newElement;
                _size = 0;
            }
            else
            {
                while (_current.NextItem != null)
                {
                    _current = _current.NextItem;
                }
                _current.NextItem = newElement;
                newElement.PrevItem = _current;
                _size++;
            }           
        }

        public void Delete(int index)
        {
            _current = _first;
            if (index < 0 || index > _size)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == 0)
            {
                _first.NextItem.PrevItem = null;
                _first = _first.NextItem;    
            }
            else
            {          
                int counter = 0;
                while (counter < index)
                {
                    _current = _current.NextItem;
                    counter++;
                }
                _current.PrevItem.NextItem = _current.NextItem;
                _current.NextItem.PrevItem = _current.PrevItem;
            }
            _size--;
        }
        public int Size { get { return _size; } }

        public bool Contains(T item)
        {
            _current = _first;
            for (int i = 0; i <= _size; i++)
            {
                {
                    if (EqualityComparer<T>.Default.Equals(_current.Item, item))
                    {
                        return true;
                    }
                    _current = _current.NextItem;
                }
            }
            return false;
        }

        public T[] ToArray()
        {
            _current = _first;
            T[] arr = new T[_size + 1];
            for (int i = 0; i <= _size; i++)
            {
                arr[i] = _current.Item;
                _current = _current.NextItem;
            }
            return arr;
        }
    }
}
