

using DataStructures.LinkedLists;

namespace DataStructures.Queues
{
    internal class CircularQueue<T> : CDT, ICircularQueue<T> where T : class, ICloneable, IComparable
    {
        private readonly ICircularlyLinkedList<T> _buffer;

        public CircularQueue() : this(ICircularlyLinkedList<T>.Create()) { }
        public CircularQueue(ICircularlyLinkedList<T> buffer)
        {
            _buffer = buffer.Clone() as ICircularlyLinkedList<T>;
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
        public T First()
        {
            if (IsEmpty()) throw new InvalidOperationException();
            return _buffer.First();
        }
        public void Rotate() { _buffer.Rotate(); }
        public object Clone() { return new CircularQueue<T>(_buffer.Clone() as ICircularlyLinkedList<T>); }
        public bool Equals(object? obj)
        {
            if (obj == null || (obj is CircularQueue<T>) == false) return false;
            var other = obj as CircularQueue<T>;
            if (other.Size() != _size) return false;
            return other._buffer.Equals(_buffer);
        }
        public override string ToString() { return _buffer.ToString(); }
    }
}
