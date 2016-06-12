using System;
using System.Collections.Generic;

namespace Dictionary
{
    class MyDictionary <TKey, TValue>
    {
        TKey[] _keys;
        TValue[] _values;

        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            foreach (var item in _keys)
            {
                if (EqualityComparer<TKey>.Default.Equals(key, item))
                {
                    throw new Exception("Key is already exists");
                }
            }
            TKey[] tempKey = new TKey[_keys.Length + 1];
            TValue[] tempValue = new TValue[_values.Length + 1];
            for (int i = 0; i < _keys.Length; i++)
            {
                tempKey[i] = _keys[i];
                tempValue[i] = _values[i];
            }
            tempKey[_keys.Length] = key;
            tempValue[_values.Length] = value;
            _keys = tempKey;
            _values = tempValue;
        }

        public bool ContainsKey(TKey key)
        {
            foreach (var item in _keys)
            {
                if (EqualityComparer<TKey>.Default.Equals(key, item))
                {
                    return true;
                }
            }
            return false;
        }
        public bool ContainsValue(TValue value)
        {
            foreach (var item in _values)
            {
                if (EqualityComparer<TValue>.Default.Equals(value, item))
                {
                    return true;
                }
            }
            return false;
        }

        public TValue this[TKey key]
        {
            get
            {
                int? index = null;
                for (int i = 0; i < _keys.Length; i++)
                {
                    if (EqualityComparer<TKey>.Default.Equals(key, _keys[i]))
                    {
                        index = i;
                    }
                }
                if (index != null)
                {
                    return _values[index.Value];
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
