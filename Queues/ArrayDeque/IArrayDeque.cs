

using DataStructures.LinkedLists;

namespace DataStructures.Queues.ArrayDeque
{
    public interface IArrayDeque<T> : IDoublyLinkedList<T> where T : class, ICloneable, IComparable
    {

    }
}
