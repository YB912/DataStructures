

namespace DataStructures.Queues
{
    internal class ArrayQueue<T> : CDT, IQueue<T> where T : class, ICloneable, IComparable
    {
        private const int DefaultCapacity = 1000;
        private readonly T[] _buffer;
        private int _head;
        public override void Clear()
        {
            throw new NotImplementedException();
        }
        public void Enqueue(T element)
        {
            throw new NotImplementedException();
        }
        public T Dequeue()
        {
            throw new NotImplementedException();
        }
        public T First()
        {
            throw new NotImplementedException();
        }
        public object Clone()
        {
            throw new NotImplementedException();
        }
        public override bool Equals(object? obj)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
