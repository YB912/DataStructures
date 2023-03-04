using DataStructures.LinkedLists;

namespace DataStructures.Stacks
{
    public interface IStack<T> : IADT, ICloneable where T : class, ICloneable, IComparable
    {
        void Push(T element);
        T Pop();
        T Peek();
        public static IStack<T> CreateArrayStack() { return new ArrayStack<T>(); }
        public static IStack<T> CreateArrayStack(int capacity) { return new ArrayStack<T>(capacity); }
        public static IStack<T> CreateLinkedStack() { return new LinkedStack<T>(); }
        public static IStack<T> CreateLinkedStack(ISinglyLinkedList<T> buffer) { return new LinkedStack<T>(buffer); }
    }
}
