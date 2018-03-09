namespace Graphs.Connectivity
{
    public class KosarajuSharirCC
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

        public KosarajuSharirCC(DirectedGraph graph)
        {
            marked = new bool[graph.V];
            _id = new int[graph.V];
            DepthFirstOrder dfo = new DepthFirstOrder(graph.Reverse());
            foreach(int v in dfo.ReversePost())
            {
                if (!marked[v])
                {
                    dfs(graph, v);
                    Count++;

                }

            }
        }

        private void dfs(DirectedGraph graph, int v)
        {
            marked[v] = true;
            _id[v] = Count;
            foreach (int w in graph.adj(v))
                if (!marked[w])
                    dfs(graph, w);
        }


        public bool StronglyConnected(int v, int w)
        {
            return _id[v] == _id[w];
        }
    }
}