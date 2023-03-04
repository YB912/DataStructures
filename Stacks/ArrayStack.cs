

namespace DataStructures.Stacks
{
    internal class ArrayStack<T> : CDT, IStack<T> where T : class, ICloneable, IComparable
    {
        private const int DefaultCapacity = 1000;
        private readonly T[] _buffer;
        private int _index = -1;

        public ArrayStack() : this(DefaultCapacity) { } 
        public ArrayStack(int capacity)
        {
            _buffer = new T[capacity];
        }
        public override void Clear()
        {
            for (int i = 0; i <= _index; i++)
            {
                Pop();
            }
        }
        public void Push(T element)
        {
            if (HasCapacity())
            {
                _buffer[++_index] = element;
                _size++;
                return;
            }
            throw new StackOverflowException();
        }
        public T Pop()
        {
            var output = _buffer[_index];
            _buffer[_index--] = null;
            _size--;
            return output;
        }
        public T Peek() { return _buffer[_index]; }
        public object Clone()
        {
            var output = new ArrayStack<T>(_buffer.Length);
            for (int i = 0; i < _size; i++)
            {
                output.Push(_buffer[i].Clone() as T);
            }
            return output;
        }
        private bool HasCapacity() { return _buffer.Length > _index + 1; }
    }
}
