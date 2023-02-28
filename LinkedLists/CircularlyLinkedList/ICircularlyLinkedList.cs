

namespace DataStructures.LinkedLists
{
    internal interface ICircularlyLinkedList<T> : ISinglyLinkedList<T> where T : class, ICloneable, IComparable
    {
        public void Rotate();
        ICircularlyLinkedList<T> Create() { return new CircularlyLinkedList<T>(); }
    }
}
