using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class Graph<T>
    {
        private Dictionary<Point<T>, HashSet<Link<T>>> graph = new Dictionary<Point<T>, HashSet<Link<T>>>();
        private bool isWeighted = false;
        public bool addEdge(T StartPointValue, T EndPointValue, int weight)
        {
            Point<T> startP = new Point<T>(StartPointValue);
            Point<T> endP = new Point<T>(EndPointValue);
            Link<T> link = new Link<T>(endP, weight);

            if (weight > 0)
            {
                isWeighted = true;
            }
            if (!graph.ContainsKey(startP))
            {
                graph.Add(startP, new HashSet<Link<T>>());
            }
            return graph[startP].Add(link);

        }
    }
}
