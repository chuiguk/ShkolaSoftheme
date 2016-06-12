

namespace Stack
{
    class MyStack <T>
    {
        T[] _arr;

        public MyStack()
        {
            _arr = new T[0];
        }

        public void Push(T item)
        {
            T[] tempArr = new T[_arr.Length + 1];
            for (int i = 0; i < _arr.Length; i++)
            {
                tempArr[i] = _arr[i];
            }
            tempArr[_arr.Length] = item;
            _arr = tempArr;
        }

        public T Pop()
        {
            T item = _arr[_arr.Length - 1];
            T[] tempArr = new T[_arr.Length - 1];
            for (int i = 0; i < _arr.Length - 1; i++)
            {
                tempArr[i] = _arr[i];
            }
            _arr = tempArr;
            return item;
        }

        public int Count
        {
            get { return _arr.Length; }
        }
    }
}
