using DataStructures.LinkedLists;

namespace DataStructures.Stacks
{
    internal class LinkedStack<T> : CDT, IStack<T> where T : class, ICloneable, IComparable
    {
        private readonly ISinglyLinkedList<T> _buffer;

        public LinkedStack() : this(ISinglyLinkedList<T>.Create()) { }
        public LinkedStack(ISinglyLinkedList<T> buffer) 
        { 
            _buffer = buffer.Clone() as ISinglyLinkedList<T>;
            _size = buffer.Size();
        }
        public override void Clear() 
        { 
            base.Clear();
            _buffer.Clear(); 
        }
        public void Push(T element) 
        { 
            _buffer.AddFirst(element); 
            _size++;
        }
        public T Pop() 
        { 
            if (IsEmpty()) { throw new InvalidOperationException(); }
            _size--;
            return _buffer.RemoveFirst();
        }
        public T Peek() 
        { 
            if (IsEmpty()) { throw new InvalidOperationException(); }
            return _buffer.First(); 
        }
        public object Clone()
        {
            var output = new LinkedStack<T>(_buffer.Clone() as ISinglyLinkedList<T>);
            output._size = _size;
            return output;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || (obj is LinkedStack<T>) == false) { return false; }
            var other = obj as LinkedStack<T>;
            return _buffer.Equals(other._buffer);
        }
        public override string ToString()
        {
            var output = "{ ";
            var newBuffer = _buffer.Clone() as ISinglyLinkedList<T>;
            for (int i =  0; i < _size; i++) 
            { 
                output += newBuffer.RemoveFirst(); 
                if (i != _size - 1) {  output += ", "; }  
            }
            output += " }";
            return output;
        }
    }
}

