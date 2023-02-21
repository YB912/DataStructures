using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.SinglyLinkedList
{
    internal class SinglyLinkedList<T> : ISinglyLinkedList<T>
    {
        public int Size()
        {
            throw new NotImplementedException();
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
        public int CompareTo(object? obj)
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
        private class Node<T> : ICloneable, IComparable
        {
            public T Element { get; private set; }
            public Node<T> Next { get; set; }
            public Node(T element)
            {
                Element= element;
                Next = null;
            }
            public object Clone()
            {
                Node<T> output = new Node<T>(Element);
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
