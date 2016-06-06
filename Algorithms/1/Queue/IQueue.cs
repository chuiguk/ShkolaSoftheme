
namespace Queue
{
    interface IQueue <T>
    {
        void Enqueue(T item);
        T Dequeue();
    }
}
