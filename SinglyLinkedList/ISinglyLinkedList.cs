

using System.Runtime.ExceptionServices;

namespace DataStructures.SinglyLinkedList
{
    internal interface ISinglyLinkedList<T> : IADT, ICloneable, IComparable
    {
        T First();
        T Last();
        void AddFirst(T element);
        void AddLast(T element);
        T RemoveFirst();
    }
}
