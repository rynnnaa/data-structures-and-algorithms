using System;
using System.Collections.Generic;
using System.Text;

namespace graph
{
    class graphz
    {
        public Dictionary<Vertex, List<Vertex>> AdjacencyList { get; set; }
        public Vertex vertex { get; set; }
        public List<Edges> Edges { get; set; }

        public graph()
        {

        }

        public int CountSize()
        {
            return AdjacencyList.Count;
        }

        public void AddNode(Vertex vertex)
        {
            AdjacencyList.Add(vertex, new List<Vertex>());
        }

        public Vertex AddEdge(Vertex p1, Vertex p2, int weight)
        {
            Edges.Add(new Edges(p1, p2, weight));
        }
    }
}

