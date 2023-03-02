namespace DataStructures.LinkedLists
{
    internal class CircularlyLinkedList<T> : SinglyLinkedList<T>, ICircularlyLinkedList<T> where T : class, ICloneable, IComparable
    {
        public override void AddFirst(T element)
        {
            if(IsEmpty())
            {
                _tail = new SingleNode(element, null);
                _tail.Next = _tail;
            } else
            {
                var added = new SingleNode(element, _tail.Next);
                _tail.Next= added;
            }
            UpdateHead();
            _size++;
        }
        public override void AddLast(T element)
        {
            AddFirst(element);
            Rotate();
            UpdateHead();
        }
        public override T RemoveFirst()
        {
            if(IsEmpty() == false)
            {
                var output = _tail.Next.Element;
                _tail.Next = _head.Next;
                UpdateHead();
                _size--;
                return output;
            }
            return default(T);
        }
        public void Rotate()
        {
            if(_tail != null) { _tail = _tail.Next; UpdateHead(); }
        }
        public override object Clone()
        {
            var output = new CircularlyLinkedList<T>();
            if (IsEmpty() == false)
            {
                var current = _head;
                for (int i = 0; i < _size; i++)
                {
                    output.AddLast(current.Element);
                    current = current.Next;
                }
            }
            return output;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if ((obj is CircularlyLinkedList<T>) == false) return false;
            var other = obj as CircularlyLinkedList<T>;
            if (_size != other._size) return false;
            var traverseThis = _head;
            var traverseOther = other._head;
            for (int i = 0; i < _size; i++)
            {
                if (traverseThis.Element.Equals(traverseOther.Element) == false) return false;
                traverseThis = traverseThis.Next;
                traverseOther = traverseOther.Next;
            }
            return true;
        }
        private void UpdateHead()
        {
            _head = _tail.Next;
        }
    }
}
