

namespace DataStructures.Queues
{
    public interface IQueue<T> : IADT, ICloneable where T : class, ICloneable, IComparable
    {
        public void Enqueue(T element);
        public T Dequeue();
        public T First();
        public static IQueue<T> CreateArrayQueue() { return new ArrayQueue<T>(); }
        public static IQueue<T> CreateArrayQueue(int capacity) { return new ArrayQueue<T>(capacity); }
        public static IQueue<T> CreateLinkedQueue() { return new LinkedQueue<T>(); }
    }
}
