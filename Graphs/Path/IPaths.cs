using System.Collections.Generic;

namespace Graphs.Path
{
    public interface IPaths
    {
        bool hasPathTo(int v);
        IEnumerable<int> pathTo(int v);
    }

}
