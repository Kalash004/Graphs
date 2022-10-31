using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class Point<T>
    {
        private T value;

        public Point(T value)
        {
            this.value = value;
        }

        public override bool Equals(object? obj)
        {
            return obj is Point<T> point &&
                   EqualityComparer<T>.Default.Equals(value, point.value);
        }

        public override string ToString()
        {
            return ""+this.value.ToString();
        }


    }
}
