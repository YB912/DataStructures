

namespace DataStructures.SinglyLinkedList
{
    internal class SinglyLinkedList<T> : ISinglyLinkedList<T> where T : class, ICloneable, IComparable
    {
        int _size;
        Node _head;
        Node _tail;
        public int Size()
        {
            return _size;
        }
        public bool IsEmpty()
        {
            return (_size== 0);
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
        public int CompareTo(object? obj)
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
        public void AddFirst(T element)
        {
            var added = new Node(element,_head);
            _head = added;
            if (IsEmpty()) { _tail = _head; }
            _size++;
        }
        public void AddLast(T element)
        {
            var added = new Node(element, null);
            if (IsEmpty()) 
            {
                _tail = _head = added;
                _size++;
                return;
            }
            _tail.Next = added;
            _tail= added;
            _size++;
        }
        public T RemoveFirst()
        {
            if (IsEmpty()) { return null; }
            var output = _head.Element;
            _head = _head.Next;
            _size--;
            return output;
        }
        class Node : ICloneable, IComparable
        {
            public T Element { get; set; }
            public Node Next { get; set; }
            public Node(T element, Node next)
            {
                Element= element;
                Next = null;
            }
            public object Clone()
            {
                Node output = new Node(Element, Next);
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
