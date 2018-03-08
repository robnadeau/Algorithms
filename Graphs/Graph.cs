using System.Collections.Generic;

namespace Graphs
{
    public class Graph
    {
        private readonly List<int>[] _adj;
        public int V { get; }
        public int E { get; private set; } 
        public override string ToString()
        {
            return null;

        }

        public IEnumerable<int> adj(int v)
        {
            return _adj[v];
        }

        //Creates an empty graph with V vertices
        public Graph(int numberOfVertices)
        {
            this.V = numberOfVertices;
            _adj = new List<int>[numberOfVertices];
            for(int v = 0; v < numberOfVertices; v++)
                _adj[v] = new List<int>();
        }

        //public Graph(In in)

        //Add an edge v-w
        void addEdge(int v, int w)
        {
            _adj[v].Add(w);
            _adj[w].Add(v);
            E++;
        }

    }
}
