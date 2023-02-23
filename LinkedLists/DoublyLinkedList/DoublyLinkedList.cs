

namespace DataStructures.LinkedLists
{
    internal class DoublyLinkedList<T> : IDoublyLinkedList<T> where T : class, ICloneable, IComparable
    {
        protected internal int _size;
        protected internal DoubleNode _headerSentinel;
        protected internal DoubleNode _tailersentinel;
        protected internal DoubleNode _head;
        protected internal DoubleNode _tail;
        public DoublyLinkedList() 
        {
            _size = 0;
            _head = _tail = null;
            _headerSentinel.Next = _tailersentinel;
            _tailersentinel.Prev = _headerSentinel;
        }
        public int Size() { return _size; }
        public bool IsEmpty() { return _size == 0; }
        public void Clear()
        {
            _size = 0;
            _head = _tail = null;
        }
        public object Clone()
        {
            throw new NotImplementedException();
        }
        public T First() { return _head.Element; }
        public T Last() { return _tail.Element; }
        public void AddFirst(T element)
        {
            DoubleNode added = new DoubleNode(element, _headerSentinel.Next, _headerSentinel);
            _headerSentinel.Next.Prev = added;
            _headerSentinel.Next = added;
            _size++;
        }
        public void AddLast(T element)
        {
            DoubleNode added = new DoubleNode(element, _tailersentinel, _tailersentinel.Prev);
            _tailersentinel.Prev.Next = added;
            _tailersentinel.Prev = added;
            _size++;
        }
        public T RemoveFirst()
        {
            T output = _head.Element;
            _headerSentinel.Next = _head.Next;
            _head.Next.Prev = _headerSentinel;
            _head = _headerSentinel.Next;
            _size--;
            return output;
        }
        public T RemoveLast()
        {
            T output = _tail.Element;
            _tailersentinel.Prev = _tail.Prev;
            _tail.Prev.Next = _tailersentinel;
            _tail = _tailersentinel.Prev;
            _size--;
            return output;
        }
        protected internal class DoubleNode : ICloneable, IComparable
        {
            public T Element;
            public DoubleNode Next;
            public DoubleNode Prev;
            public DoubleNode(T element)
            {
                Element = element;
                Next = Prev = null;
            }
            public DoubleNode(T element, DoubleNode next, DoubleNode prev)
            {
                Element = element;
                Next = next;
                Prev = prev;
            }
            public object Clone()
            {
                return new DoubleNode(Element, Next, Prev);
            }
            public int CompareTo(object? obj)
            {
                if ((obj is DoubleNode) == false) return -1;
                DoubleNode other = obj as DoubleNode;
                return Element.CompareTo(other.Element);
            }
        }
    }
}
