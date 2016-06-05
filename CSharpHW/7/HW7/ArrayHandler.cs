using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class ArrayHandler
    {
        int[] _arr = new int[10000];
        public Dictionary<int, int> _counter = new Dictionary<int, int>();
        public ArrayHandler()
        {
            ArrayFill();
            Count();
        }
        void ArrayFill()
        {
            var rand = new Random();
            for (int i = 0; i < _arr.Length; i++)
            {
                _arr[i] = rand.Next(1000);
            }
            foreach (var item in _arr)
            {
                if(!_counter.ContainsKey(item))
                _counter.Add(item, 1);
            }
        }
        void Count()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                _counter[_arr[i]] += 1;
            }
        }

    }
}
