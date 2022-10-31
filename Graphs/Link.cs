using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class Link<T>
    {
        private Point<T> point2;
        private int weight;

        public Link(Point<T> point2, int weight)
        {
            this.point2 = point2;
            this.weight = weight;
        }
    }
}
