using System;
using Xunit;

namespace Graphs.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Graph g = new Graph(12);
            Paths paths = new Paths(g,s);
            for(int v = 0; v < g.V; v++)
                Console.WriteLine(v);
        }
    }
}
