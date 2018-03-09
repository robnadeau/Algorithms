namespace Graphs.Connectivity
{
    public class CC : IConnectivity
    {
        private bool[] marked;
        private int[] _id;
        public int Count { get; private set; }

        public int this[int i] 
        {
            get
            {
                return  _id[i];
            }

        }

        public CC(UndirectedGraph graph)
        {
            marked = new bool[graph.V];
            _id = new int[graph.V];
            for (int v = 0; v < graph.V; v++)
            {
                if (!marked[v])
                {
                    dfs(graph, v);
                    Count++;

                }
            }
        }

        private void dfs(UndirectedGraph graph, int v)
        {
            marked[v] = true;
            _id[v] = Count;
            foreach (int w in graph.adj(v))
                if (!marked[w])
                    dfs(graph, w);
        }


        public bool Connected(int v, int w)
        {
            return _id[v] == _id[w];
        }
    }
}