
namespace HW15
{
    class Element <T>
    {
        public T Item { get; set; }
        public Element<T> NextItem { get; set; }
        public Element<T> PrevItem { get; set; }

        public Element(T item)
        {
            Item = item;
        }
    }
}
