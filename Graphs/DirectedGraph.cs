using System.Collections.Generic;

namespace Graphs
{
    public class DepthFirstOrder
    {
        private bool[] marked;
        private Stack<int> reversePost;

        public DepthFirstOrder(DirectedGraph graph)
        {
            reversePost = new Stack<int>();
            marked = new bool[graph.V];
            for (int v = 0; v < graph.V; v++)
            {
                if (!marked[v]) dfs(graph, v);
            }
        }
        private void dfs(DirectedGraph graph, int v)
        {
            marked[v] = true;
            foreach(int w in graph.adj(v))
                if (!marked[w])
                    dfs(graph, w);
            
            reversePost.Push(v);
        }

        public IEnumerable<int> ReversePost()
        {
            return reversePost;
        }

    }
    public class DirectedGraph
    {
        public DirectedGraph(int numberOfVertices)
        {
            this.V = numberOfVertices;
            _adj = new List<int>[numberOfVertices];
            for(int v = 0; v < numberOfVertices; v++)
                _adj[v] = new List<int>();
        }

        void addEdge(int v, int w)
        {
            _adj[v].Add(w);
            E++;
        }

        public IEnumerable<int> adj(int v)
        {
            return _adj[v];
        }

        public DirectedGraph Reverse()
        {
            return new DirectedGraph(V);
        }

        public override string ToString()
        {
            return null;

        }

        private readonly List<int>[] _adj;
        public int V { get; private set; }
        public int E { get; private set; } 
    }
}
