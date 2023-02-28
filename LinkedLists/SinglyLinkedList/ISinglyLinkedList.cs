namespace DataStructures.LinkedLists
{
    internal interface ISinglyLinkedList<T> : IADT, ICloneable where T : class, ICloneable, IComparable
    {
        T First();
        T Last();
        void AddFirst(T element);
        void AddLast(T element);
        T RemoveFirst();
        ISinglyLinkedList<T> Create() { return new SinglyLinkedList<T>(); }
    }
}
