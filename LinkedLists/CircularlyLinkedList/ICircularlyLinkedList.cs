

namespace DataStructures.LinkedLists
{
    public interface ICircularlyLinkedList<T> : ISinglyLinkedList<T> where T : class, ICloneable, IComparable
    {
        public void Rotate();
        static ICircularlyLinkedList<T> Create() { return new CircularlyLinkedList<T>(); }
    }
}
