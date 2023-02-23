

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
            _headerSentinel = _tailersentinel = _head = _tail = null;
        }
        public int Size()
        {
            return _size;
        }
        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }
        public void Clear()
        {
            throw new NotImplementedException();
        }
        public object Clone()
        {
            throw new NotImplementedException();
        }
        public T First()
        {
            throw new NotImplementedException();
        }
        public T Last()
        {
            throw new NotImplementedException();
        }
        public void AddFirst(T element)
        {
            throw new NotImplementedException();
        }
        public void AddLast(T element)
        {
            throw new NotImplementedException();
        }
        public T RemoveFirst()
        {
            throw new NotImplementedException();
        }
        public T RemoveLast()
        {
            throw new NotImplementedException();
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
                throw new NotImplementedException();
            }
        }
    }
}
