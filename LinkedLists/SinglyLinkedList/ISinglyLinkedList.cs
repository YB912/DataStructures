namespace DataStructures.LinkedLists
{
    internal interface ISinglyLinkedList<T> : IADT, ICloneable
    {
        T First();
        T Last();
        void AddFirst(T element);
        void AddLast(T element);
        T RemoveFirst();
    }
}
