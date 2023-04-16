

namespace DataStructures.Queues
{
    internal class ArrayDeque<T> : CDT, IArrayDeque<T> where T : class, ICloneable, IComparable
    {
        private const int DefaultCapacity = 1000;
        private readonly T[] _buffer;
        private int _head;
        private int _tail;

        public ArrayDeque() : this(DefaultCapacity) { }
        public ArrayDeque(int capacity) 
        { 
            _buffer = new T[capacity];
            _head = 0;
            _tail = 0;
        }
        
        public void Clear()
        {
            for (int i = 0; i < _size; i++) 
            {
                RemoveFirst();
            }
            _head = 0;
            _tail = 1;
        }
        public T First() { return _buffer[_head]; }
        public T Last() { return _buffer[_tail]; }
        public void AddFirst(T element) 
        {
            Add(_head, element);
            CheckCircularity(--_head);
        }
        public void AddLast(T element)
        {
            Add(_tail, element);
            CheckCircularity(++_tail);
        }
        public T RemoveFirst()
        {
            return Remove(_head);
        }
        public T RemoveLast()
        {
            return Remove(_tail);
        }
        public object Clone()
        {
            var output = new ArrayDeque<T>(_buffer.Length);
            var index = _head;
            for (int i = 0; i < _size; i++)
            {
                output.AddLast(_buffer[index++]);
            }
            return output;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || (obj is ArrayDeque<T>) == false) return false;
            var other = obj as ArrayDeque<T>;
            if (other.Size() != _size) return false;
            var currentIndex = _head;
            for (int i = 0; i < _size; i++)
            {
                if (_buffer[currentIndex].Equals(other._buffer[currentIndex]) == false) return false;
                currentIndex++;
                if (currentIndex >= _buffer.Length) { currentIndex = 0; }
            }
            return true;
        }
        public override string ToString()
        {
            var output = "{ ";
            var currentIndex = _head;
            for (int i = 0; i < _size; i++)
            {
                output += _buffer[currentIndex++].ToString();
                if (i != _size - 1) { output += ", "; }
            }
            output += "}";
            return output;
        }
        private bool HasCapacity() { return _buffer.Length > _size; }
        private void CheckCircularity(int side)
        {
            if (side == -1) { side = _buffer.Length - 1; }
            else if (side == _buffer.Length) { side = 0; }
        }
        private void Add(int side, T element)
        {
            if (HasCapacity() == false) { throw new InternalBufferOverflowException(); }
            _buffer[side] = element;
            _size++;
        }
        private T Remove(int side)
        {
            if (IsEmpty()) throw new InvalidOperationException();
            var output = _buffer[side];
            _buffer[side] = null;
            _size--;
            if (IsEmpty()) { _head = _tail = 0; }
            else
            {
                _ = side == _head ? _head++ : _tail--;
                CheckCircularity(side);
            }
            return output;
        }
    }
}
