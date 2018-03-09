using System.Collections.Generic;

namespace Graphs.Path
{
    public class BreadthFirstPaths : IPaths
    {
        private bool[] marked;
        private int[] edgeTo;
        private readonly int s;

        public BreadthFirstPaths(UndirectedGraph graph, int s)
        {
            marked = new bool[graph.V];
            edgeTo = new int[graph.V];
            this.s = s;
        }

        private void bfs(UndirectedGraph graph, int s)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(s);
            marked[s] = true;
            while(queue.Count != 0)
            {
                int v = queue.Dequeue();
                foreach(int w in graph.adj(v))
                {
                    if (!marked[w])
                    {
                        queue.Enqueue(w);
                        marked[w] = true;
                        edgeTo[w] = v;
                    }
                }
            }
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
    }
}
