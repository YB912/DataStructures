

namespace DataStructures.Stacks
{
    internal class ArrayStack<T> : CDT, IStack<T> where T : class, ICloneable, IComparable
    {
        private const int DefaultCapacity = 1000;
        private readonly T[] _buffer;
        private int _index = -1;

        public ArrayStack() : this(DefaultCapacity) { } 
        public ArrayStack(int capacity) { _buffer = new T[capacity]; }
        public override void Clear()
        {
            var currentCount = _index;
            for (int i = 0; i <= currentCount; i++)
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
            if (IsEmpty()) { throw new InvalidOperationException(); }
            var output = _buffer[_index];
            _buffer[_index--] = null;
            _size--;
            return output;
        }
        public T Peek() 
        { 
            if (IsEmpty()) { throw new InvalidOperationException(); }
            return _buffer[_index]; 
        }
        public object Clone()
        {
            var output = new ArrayStack<T>(_buffer.Length);
            for (int i = 0; i < _size; i++)
            {
                output.Push(_buffer[i].Clone() as T);
            }
            return output;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || (obj is ArrayStack<T>) == false) { return false; }
            var other = obj as ArrayStack<T>;
            if (_size != other.Size()) { return false; }
            for (int i = 0; i < _size; ++i) { if (_buffer[i] != other._buffer[i]) { return false; } }
            return true;
        }
        public override string ToString()
        {
            var output = "{ ";
            for (int i = _size - 1; i >= 0; i--)
            {
                output += _buffer[i].ToString();
                if (i != _size - 1) { output += ", "; }
            }
            output += " }";
            return output;
        }
        private bool HasCapacity() { return _buffer.Length > _index + 1; }
    }
}
