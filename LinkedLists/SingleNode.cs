

namespace DataStructures.LinkedLists
{
    internal class SingleNode<T> : ISingleNode<T> where T : IComparable
    {
        public T Element { get; set; }
        public SingleNode<T> Next { get; set; }
        public SingleNode(T element, SingleNode<T> next)
        {
            Element = element;
            Next = null;
        }
        public object Clone()
        {
            var output = new SingleNode<T>(Element, Next);
            output.Next = Next;
            return output;
        }
        public int CompareTo(object? obj)
        {
            return Element.CompareTo(((SingleNode<T>)obj).Element);
        }
    }
}
