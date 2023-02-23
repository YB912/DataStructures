

namespace DataStructures.LinkedLists
{
    internal interface IDoublyLinkedList<T> : ISinglyLinkedList<T>
    {
        public T RemoveLast();
    }
}
