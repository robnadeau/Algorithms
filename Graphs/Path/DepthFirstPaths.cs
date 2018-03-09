using System.Collections.Generic;

namespace Graphs.Path
{
    public class DepthFirstPaths : IPaths
    {
        private readonly int s;
        private bool[] marked;
        private int[] edgeTo;
        public DepthFirstPaths(UndirectedGraph graph, int s)
        {
            marked = new bool[graph.V];
            edgeTo = new int[graph.V];
            this.s = s;
            dfs(graph, s);
        }

        public bool hasPathTo(int v)
        {
            return marked[v];
        }

        public IEnumerable<int> pathTo(int v)
        {
            if (!hasPathTo(v)) return null;
            Stack<int> path = new Stack<int>();
            for(int x = v; x!=s; x = edgeTo[x])
            {
                path.Push(x);
            }
            path.Push(s);
            return path;
        }

        private void dfs(UndirectedGraph graph, int v)
        {
            marked[v] = true;
            foreach(int w in graph.adj(v))
            {
                if (!marked[w])
                {
                    dfs(graph, w);
                    edgeTo[w] = v;
                }
            }
        }
    }
}
