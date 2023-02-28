

namespace DataStructures.LinkedLists
{
    public interface IDoublyLinkedList<T> : ISinglyLinkedList<T> where T : class, ICloneable, IComparable
    {
        public T RemoveLast();
        static IDoublyLinkedList<T> Create() { return new DoublyLinkedList<T>(); }
    }
}
