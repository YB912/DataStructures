namespace DataStructures.LinkedLists
{
    public interface ISinglyLinkedList<T> : IADT, ICloneable where T : class, ICloneable, IComparable
    {
        T First();
        T Last();
        void AddFirst(T element);
        void AddLast(T element);
        T RemoveFirst();
        static ISinglyLinkedList<T> Create() { return new SinglyLinkedList<T>(); }
    }
}
