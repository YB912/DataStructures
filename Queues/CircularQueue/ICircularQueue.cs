

namespace DataStructures.Queues
{
    internal interface ICircularQueue<T> : IQueue<T> where T : class, ICloneable, IComparable
    {
        public void Rotate();
        public static ICircularQueue<T> Create() { return new CircularQueue<T>();}
    }
}
