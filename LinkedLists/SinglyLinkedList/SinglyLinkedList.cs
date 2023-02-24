namespace DataStructures.LinkedLists
{
    internal class SinglyLinkedList<T> : ISinglyLinkedList<T> where T : class, ICloneable, IComparable
    {
        protected internal int _size;
        protected internal SingleNode _head;
        protected internal SingleNode _tail;
        public SinglyLinkedList() 
        {
            _size = 0;
            _head = _tail = null;
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
        public T? First() { return _head.Element; }
        public T? Last() { return _tail.Element; }
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
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if ((obj is SinglyLinkedList<T>) == false) return false;
            var other = obj as SinglyLinkedList<T>;
            if (_size != other._size) return false;
            var traverseThis = _head;
            var traverseOther = other._head;
            while (traverseThis != null)
            {
                if (traverseThis.Element.Equals(traverseOther.Element) == false) return false;
                traverseThis = traverseThis.Next;
                traverseOther = traverseOther.Next;
            }
            return true;
        }
        protected internal class SingleNode : ICloneable, IComparable
        {
            public T Element { get; set; }
            public SingleNode Next { get; set; }
            public SingleNode(T element) 
            {
                Element = element;
                Next = null;
            }
            public SingleNode(T element, SingleNode next)
            {
                Element = element;
                Next = next;
            }
            public object Clone()
            {
                return new SingleNode(Element, Next);
            }
            public int CompareTo(object? obj)
            {
                if ((obj is SingleNode) == false) return -1;
                var other = obj as SingleNode;
                return Element.CompareTo(other.Element);
            }
        }
    }
}
