

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
        private void UpdateHead()
        {
            _head = _tail.Next;
        }
    }
}
