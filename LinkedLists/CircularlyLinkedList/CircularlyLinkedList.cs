

namespace DataStructures.LinkedLists
{
    internal class CircularlyLinkedList<T> : SinglyLinkedList<T>, ICircularlyLinkedList<T> where T : class, ICloneable, IComparable
    {
        public override void AddFirst(T element)
        {
            throw new NotImplementedException();
        }
        public override void AddLast(T element)
        {
            throw new NotImplementedException();
        }
        public override T RemoveFirst()
        {
            throw new NotImplementedException();
        }
        public void Rotate()
        {
            throw new NotImplementedException();
        }
    }
}
