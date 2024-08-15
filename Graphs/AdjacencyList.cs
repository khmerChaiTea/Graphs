using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Graphs
{
    public class AdjacencyList
    {
        public Dictionary<int, LinkedList<int>> list = new();

        public AdjacencyList(int verticesSize)
        {
            for (int i = 0; i < verticesSize; i++)
            {
                list.Add(i, new());
            }
        }

        public void AddEdge(int src, int dest)
        {
            if (list.TryGetValue(src, out LinkedList<int>? value))
            {
                value.AddFirst(dest);
            }
            else
            {
                // Initialize the LinkedList if it doesn't exist
                value = new LinkedList<int>();
                value.AddFirst(dest);
                list[src] = value;
            }

            // Assuming undirected graph, add the reverse edge as well
            if (list.TryGetValue(dest, out LinkedList<int>? destValue))
            {
                destValue.AddFirst(src);
            }
            else
            {
                // Initialize the LinkedList if it doesn't exist
                destValue = new LinkedList<int>();
                destValue.AddFirst(src);
                list[dest] = destValue;
            }
        }

        public bool ContainsEdge(int src, int dest)
        {
            LinkedList<int>? value;
            list.TryGetValue(src, out value);
            if (value == null) return false;
            return value.Contains(dest);
        }
    }
}
