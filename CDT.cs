

namespace DataStructures
{
    internal abstract class CDT : IADT
    {
        protected internal int _size;
        public int Size() { return _size; }
        public bool IsEmpty() { return _size == 0; }
        public virtual void Clear() { _size = 0; }
    }
}
