

namespace DataStructures.LinkedLists
{
    internal interface ICircularlyLinkedList<T> : ISinglyLinkedList<T>
    {
        public void Rotate();
    }
}
