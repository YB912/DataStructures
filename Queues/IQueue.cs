

namespace DataStructures.Queues
{
    public interface IQueue<T> : IADT, ICloneable where T : class, ICloneable, IComparable
    {
        public void Enqueue(T element);
        public T Dequeue();
        public T First();
    }
}
