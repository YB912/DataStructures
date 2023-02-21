using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedLists
{
    internal interface ISingleNode<T> : ICloneable, IComparable where T : IComparable
    {
        public T Element { get; set; }
        public SingleNode<T> Next { get; set; }
    }
}
