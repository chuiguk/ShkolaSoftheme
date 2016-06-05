using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class MyList
    {
        int[] _arr = new int[0];
        public void Add(int item)
        {
            int[] tempArr = new int[_arr.Length + 1];
            for (int i = 0; i < _arr.Length; i++)
            {
                tempArr[i] = _arr[i];
            }
            tempArr[_arr.Length] = item;
            _arr = tempArr;
        }
        public bool Contains(int item)
        {
            foreach (var i in _arr)
            {
                if(item == i)
                {
                    return true;
                }
            }
            return false;
        }
        public int GetByIndex(int index)
        {
            if(index < _arr.Length)
            {
                return _arr[index];
            }
            throw new IndexOutOfRangeException();
        }
        public int this[int index]
        {
            get 
            {
                if (index < _arr.Length)
                {
                    return _arr[index];
                }
                throw new IndexOutOfRangeException();
            }
        }
    }
}
