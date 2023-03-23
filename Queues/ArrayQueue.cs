

namespace DataStructures.Queues
{
    internal class ArrayQueue<T> : CDT, IQueue<T> where T : class, ICloneable, IComparable
    {
        private const int DefaultCapacity = 1000;
        private readonly T[] _buffer;
        private int _head;
        private int _tail;
        
        public ArrayQueue() : this(DefaultCapacity) { }
        public ArrayQueue(int capacity)
        {
            _buffer = new T[capacity];
            _head = _tail = 0;
        }
        public override void Clear()
        {
            for (int i = 0; i < _size; i++) Dequeue(); 
            _head = _tail = 0;
        }
        public void Enqueue(T element)
        {
            if (HasCapacity())
            {
                _buffer[_tail++] = element;
                _size++;
                if (_tail == _buffer.Length) { _tail = 0; }
                return;
            }
            throw new InternalBufferOverflowException();
        }
        public T Dequeue()
        {
            if (IsEmpty()) throw new InvalidOperationException();
            var output = _buffer[_head];
            _buffer[_head++] = null;
            _size--;
            if (_head == _buffer.Length) _head = 0;
            return output;
        }
        public T First()
        {
            if (IsEmpty()) throw new InvalidOperationException();
            return _buffer[_head];
        }
        public object Clone()
        {
            var output = new ArrayQueue<T>(_buffer.Length);
            output._head = output._tail = _head;
            var currentIndex = _head;
            for (int i = 0; i < _size; i++) output.Enqueue(_buffer[currentIndex++]);
            return output;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || (obj is ArrayQueue<T>) == false) return false;
            var other = obj as ArrayQueue<T>;
            if (other.Size() != _size) return false;
            var currentIndex = _head;
            for (int i = 0; i < _size; i++)
            {
                if (_buffer[currentIndex].Equals(other._buffer[currentIndex]) == false) return false;
                currentIndex++;
                if (currentIndex >= _buffer.Length) currentIndex = 0;
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
    }
}
