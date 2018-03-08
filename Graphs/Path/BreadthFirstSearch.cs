using System.Collections.Generic;

namespace Graphs.Path
{
    public class BreadthFirstSearch : IPaths
    {
        private bool[] marked;
        private int[] edgeTo;
        private readonly int s;

        public BreadthFirstSearch(Graph graph, int s)
        {
            marked = new bool[graph.V];
            edgeTo = new int[graph.V];
            this.s = s;
        }
        
        private void bfs(Graph graph, int s)
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
            throw new System.NotImplementedException();
        }

        public IEnumerable<int> pathTo(int v)
        {
            throw new System.NotImplementedException();
        }
    }
}
