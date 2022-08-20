namespace algorithms
{
    public class Graph
    {
        private int _V;
        LinkedList<int>[] _adj;

        public Graph(int V)
        {
            _adj = new LinkedList<int>[V];
            for (int i = 0; i < V; i++)
            {
                _adj[i] = new LinkedList<int>();
            }
            _V = V;
        }

        public void AddEdge(int v, int w)
        {
            _adj[v].AddLast(w);
        }

        public void BFS(int node)
        {
            bool[] visited = new bool[_V];

            for (int i = 0; i < _V; i++)
            {
                visited[i] = false;
            }

            LinkedList<int> queue = new LinkedList<int>();

            visited[node] = true;
            queue.AddLast(node);

            while (queue.Any())
            {
                node = queue.First();
                Console.Write($"{node}\t");
                queue.RemoveFirst();

                LinkedList<int> neighbors = _adj[node];

                foreach (var n in neighbors)
                {
                    if (!visited[n])
                    {
                        visited[n] = true;
                        queue.AddLast(n);
                    }
                }
            }
        }

        private void recursiveDFS(int node, bool[] visited)
        {
            Console.Write($"{node}\t");
            visited[node] = true;

            foreach (int neighbor in _adj[node])
            {
                if(!visited[neighbor]) {
                    recursiveDFS(neighbor, visited);
                }
            }
        }

        public void DFS(int s)
        {
            bool[] visited = new bool[_V];

            recursiveDFS(s, visited);
        }
    }
}