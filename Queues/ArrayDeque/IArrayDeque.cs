using DataStructures.LinkedLists;

namespace DataStructures.Queues  
{
    public interface IArrayDeque<T> : IDoublyLinkedList<T> where T : class, ICloneable, IComparable
    {
        public static IArrayDeque<T> Create() { return new ArrayDeque<T>(); }
        public static IArrayDeque<T> Create(int capacity) {  return new ArrayDeque<T>(capacity); }
    }
}
