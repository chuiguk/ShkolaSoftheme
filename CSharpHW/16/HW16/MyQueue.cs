

namespace HW16
{
    class MyQueue <T>
    {
        T[] _arr;

        public MyQueue()
        {
            _arr = new T[0];
        }

        public void Enqueue(T item)
        {
            T[] tempArr = new T[_arr.Length + 1];
            for (int i = 0; i < _arr.Length; i++)
            {
                tempArr[i] = _arr[i];
            }
            tempArr[_arr.Length] = item;
            _arr = tempArr;
        }

        public T Dequeue()
        {
            T item = _arr[0];
            T[] tempArr = new T[_arr.Length - 1];
            for (int i = 1; i < _arr.Length; i++)
            {
                tempArr[i - 1] = _arr[i];
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
