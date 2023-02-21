using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedLists
{
    public class SingleNode<T> : ICloneable, IComparable
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
            throw new NotImplementedException();
        }
    }
}
