using System;
using System.Collections.Generic;
using System.Text;

namespace graph
{
    class Edges
    {
        public Vertex StartA { get; set; }
        public Vertex StartB { get; set; }
        public int Weight { get; set; }

        public Edges(Vertex a, Vertex b, int weight)
        {
            StartA = a;
            StartB = b;
            Weight = weight;
        }
    }

}
