namespace Graphs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdjacencyList list = new AdjacencyList(10);
            list.AddEdge(0, 1);
            list.AddEdge(0, 2);
            list.AddEdge(1, 2);
            list.AddEdge(1, 3);
            list.AddEdge(2, 4);
            list.AddEdge(3, 4);
            list.AddEdge(4, 5);
            list.AddEdge(5, 6);
            list.AddEdge(7, 9);
            list.AddEdge(8, 9);
            Console.WriteLine(list.ContainsEdge(1, 3));
            Console.WriteLine(list.ContainsEdge(0, 9));
        }
    }
}
