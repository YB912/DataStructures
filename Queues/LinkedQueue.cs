using DataStructures.LinkedLists;

namespace DataStructures.Queues
{
    internal class LinkedQueue<T> : CDT, IQueue<T> where T : class, ICloneable, IComparable
    {
        private readonly ISinglyLinkedList<T> _buffer;

        public LinkedQueue() : this(ISinglyLinkedList<T>.Create()) { }
        public LinkedQueue(ISinglyLinkedList<T> buffer)
        {
            _buffer = buffer.Clone() as ISinglyLinkedList<T>;
            _size = buffer.Size();
        }
        public void Clear()
        {
            _buffer.Clear();
            _size = 0;
        }
        public void Enqueue(T element)
        {
            _buffer.AddLast(element);
            _size++;
        }
        public T Dequeue()
        {
            if (IsEmpty()) throw new InvalidOperationException();
            _size--;
            return _buffer.RemoveFirst();
        }
        public T First() { return _buffer.First(); }
        public object Clone() { return new LinkedQueue<T>(_buffer.Clone() as ISinglyLinkedList<T>); }
        public override bool Equals(object? obj) 
        {
            if (obj == null || (obj is LinkedQueue<T>) == false ) return false;
            var other = obj as LinkedQueue<T>;
            if (other.Size() != _size) return false;
            return other._buffer.Equals(_buffer);
        }
        public override string ToString() { return _buffer.ToString(); }
    }
}
