

namespace DataStructures.LinkedLists
{
    internal class DoublyLinkedList<T> : IDoublyLinkedList<T> where T : class, ICloneable, IComparable
    {
        protected internal int _size;
        protected internal DoubleNode _headerSentinel;
        protected internal DoubleNode _tailersentinel;
        public DoublyLinkedList() 
        {
            _size = 0;
            _headerSentinel = new DoubleNode(null, null, null);
            _tailersentinel = new DoubleNode(null, null, _headerSentinel);
        }
        public int Size() { return _size; }
        public bool IsEmpty() { return _size == 0; }
        public void Clear()
        {
            _size = 0;
            _headerSentinel.Next = _tailersentinel.Prev = null;
        }
        public object Clone()
        {
            throw new NotImplementedException();
        }
        public T First() { return _headerSentinel.Next.Element; }
        public T Last() { return _tailersentinel.Prev.Element; }
        public void AddFirst(T element) { AddBetween(element, _headerSentinel, _headerSentinel.Next); }
        public void AddLast(T element) { AddBetween(element, _tailersentinel.Prev, _tailersentinel); }
        public T RemoveFirst() { return Remove(_headerSentinel.Next); }
        public T RemoveLast() { return Remove(_tailersentinel.Prev); }
        private void AddBetween(T element, DoubleNode prev, DoubleNode next) 
        {
            DoubleNode added = new DoubleNode(element, prev, next);
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
