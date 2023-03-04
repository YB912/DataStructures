using DataStructures.LinkedLists;

namespace DataStructures.Stacks
{
    internal class LinkedStack<T> : CDT, IStack<T> where T : class, ICloneable, IComparable
    {
        private readonly ISinglyLinkedList<T> _buffer;

        public LinkedStack() : this(ISinglyLinkedList<T>.Create()) { }
        public LinkedStack(ISinglyLinkedList<T> buffer) { _buffer = buffer; }
        public override void Clear() { _buffer.Clear(); }
        public void Push(T element) { _buffer.AddFirst(element); }
        public T Pop() { return _buffer.RemoveFirst(); }
        public T Peek() { return _buffer.First(); }
        public object Clone()
        {
            var output = new LinkedStack<T>(_buffer.Clone() as ISinglyLinkedList<T>);
            output._size = _size;
            return output;
        }
    }
}

