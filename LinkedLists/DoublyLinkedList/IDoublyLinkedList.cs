

namespace DataStructures.LinkedLists
{
    internal interface IDoublyLinkedList<T> : ISinglyLinkedList<T> where T : class, ICloneable, IComparable
    {
        public T RemoveLast();
        IDoublyLinkedList<T> Create() { return new DoublyLinkedList<T>(); }
    }
}
