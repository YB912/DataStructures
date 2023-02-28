﻿namespace DataStructures.LinkedLists
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
            if (_size > 0)
            {
                output._head = new SingleNode(_head.Element, null);
                var iteratorOfThis = _head.Next;
                var iteratorOfOther = output._head;
                for (int i = 1; i < _size; i++)
                {
                    var newNode = new SingleNode(iteratorOfThis.Element, null);
                    iteratorOfOther.Next = newNode;
                    iteratorOfOther = newNode;
                    iteratorOfThis = iteratorOfThis.Next;
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
