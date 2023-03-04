

namespace DataStructures.Stacks
{
    internal interface IStack<T> : IADT, ICloneable where T : class, ICloneable, IComparable
    {
        void Push(T element);
        T Pop();
        T Peek();
    }
}
