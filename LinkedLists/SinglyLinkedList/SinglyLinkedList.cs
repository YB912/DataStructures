namespace DataStructures.LinkedLists
{
    internal class SinglyLinkedList<T> : ISinglyLinkedList<T> where T : class, ICloneable, IComparable
    {
        protected internal int _size;
        protected internal SingleNode _head;
        protected internal SingleNode _tail;
        public int Size()
        {
            return _size;
        }
        public bool IsEmpty()
        {
            return _size == 0;
        }
        public void Clear()
        {
            _head = null;
            _tail = null;
            _size = 0;
        }
        public object Clone()
        {
            throw new NotImplementedException();
        }
        public T? First()
        {

            return _head.Element;
        }
        public T? Last()
        {
            return _tail.Element;
        }
        public virtual void AddFirst(T element)
        {
            var added = new SingleNode(element, _head);
            _head = added;
            if (IsEmpty()) { _tail = _head; }
            _size++;
        }
        public virtual void AddLast(T element)
        {
            var added = new SingleNode(element, null);
            if (IsEmpty())
            {
                _tail = _head = added;
                _size++;
                return;
            }
            _tail.Next = added;
            _tail = added;
            _size++;
        }
        public virtual T RemoveFirst()
        {
            if (IsEmpty()) { return null; }
            var output = _head.Element;
            _head = _head.Next;
            _size--;
            return output;
        }
        protected internal class SingleNode : ICloneable, IComparable
        {
            public T Element { get; set; }
            public SingleNode Next { get; set; }
            public SingleNode(T element, SingleNode next)
            {
                Element = element;
                Next = null;
            }
            public object Clone()
            {
                SingleNode output = new SingleNode(Element, Next);
                output.Next = Next;
                return output;
            }
            public int CompareTo(object? obj)
            {
                throw new NotImplementedException();
            }
        }
    }
}
