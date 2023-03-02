namespace DataStructures.LinkedLists
{
    internal class DoublyLinkedList<T> : CDT, IDoublyLinkedList<T> where T : class, ICloneable, IComparable
    {
        protected internal DoubleNode _headerSentinel;
        protected internal DoubleNode _tailersentinel;
        public DoublyLinkedList() 
        {
            _size = 0;
            _headerSentinel = new DoubleNode(null, null, null);
            _tailersentinel = new DoubleNode(null, _headerSentinel, null);
            _headerSentinel.Next = _tailersentinel;
        }
        public void Clear()
        {
            base.Clear();
            _headerSentinel.Next = _tailersentinel.Prev = null;
        }
        public T First() { return _headerSentinel.Next.Element; }
        public T Last() { return _tailersentinel.Prev.Element; }
        public void AddFirst(T element) { AddBetween(element, _headerSentinel, _headerSentinel.Next); }
        public void AddLast(T element) { AddBetween(element, _tailersentinel.Prev, _tailersentinel); }
        public T RemoveFirst() { return Remove(_headerSentinel.Next); }
        public T RemoveLast() { return Remove(_tailersentinel.Prev); }
        public object Clone()
        {
            var output = new DoublyLinkedList<T>();
            if (IsEmpty() == false)
            {
                var current = _headerSentinel.Next;
                for (int  i = 0; i < _size; i++)
                {
                    output.AddLast(current.Element.Clone() as T);
                    current = current.Next;
                }
            }
            return output;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if ((obj is DoublyLinkedList<T>) == false) return false;
            var other = obj as DoublyLinkedList<T>;
            if (_size != other._size) return false;
            var traverseThis = _headerSentinel.Next;
            var traverseOther = other._headerSentinel.Next;
            for (int i = 0; i < _size; i++)
            {
                if (traverseThis.Element.Equals(traverseOther.Element) == false) return false;
                traverseThis = traverseThis.Next;
                traverseOther = traverseOther.Next;
            }
            return true;
        }
        public override string ToString()
        {
            string output = "{ ";
            DoubleNode current = _headerSentinel.Next;
            for (int i = 0; i < _size; i++)
            {
                output += current.Element.ToString();
                if (i != _size - 1)
                {
                    output += ", ";
                }
                current = current.Next;
            }
            output += " }";
            return output;
        }
        private void AddBetween(T element, DoubleNode prev, DoubleNode next) 
        {
            var added = new DoubleNode(element, prev, next);
            prev.Next = added;
            next.Prev = added;
            _size++;
        }
        private T Remove(DoubleNode node) 
        {
            var output = node.Element;
            node.Prev.Next = node.Next;
            node.Next.Prev = node.Prev;
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
            public DoubleNode(T element, DoubleNode prev, DoubleNode next)
            {
                Element = element;
                Prev = prev;
                Next = next;
            }
            public object Clone()
            {
                return new DoubleNode(Element, Prev, Next);
            }
            public int CompareTo(object? obj)
            {
                if ((obj is DoubleNode) == false) return -1;
                var other = obj as DoubleNode;
                return Element.CompareTo(other.Element);
            }
        }
    }
}
