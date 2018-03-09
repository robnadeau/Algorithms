namespace Graphs.Connectivity
{
    public interface IConnectivity
    {
        bool Connected(int v, int w);
        int Count { get; }
        int this[int i] { get; }
    }
}