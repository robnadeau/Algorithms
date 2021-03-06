namespace Graphs
{
    public static class GraphExtensions
    {
        public static int degree (this UndirectedGraph graph, int v)
        {
            int degree = 0;
            foreach(int w in graph.adj(v))
                degree++;
            return degree;
        }

        public static int maxDegree(this UndirectedGraph graph)
        {
            int max = 0;
            for (int v = 0; v < graph.V; v++)
                if (graph.degree(v)>max)
                    max = graph.degree(v);
            
            return max;
        }

        public static double averageDegree(this UndirectedGraph graph)
        {
            return 2.0*graph.E/graph.V;
        }

        public static int numberOfSelfLoops(this UndirectedGraph graph)
        {
            int count = 0;
            for(int v = 0; v < graph.V; v++)
                foreach(int w in graph.adj(v))
                    if (v == w) count++;
            return count/2;
        }
    }
}
