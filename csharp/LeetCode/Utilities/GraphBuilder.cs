namespace LeetCode.Utilities;

public static class GraphBuilder
{
    public static Node? FromAdjacencyList(int[][] adjacencyList)
    {
        if (adjacencyList.Length == 0)
        {
            return null;
        }

        var nodes = new Node[adjacencyList.Length];

        for (var i = 0; i < nodes.Length; i++)
        {
            nodes[i] = new Node(i + 1);
        }

        for (var i = 0; i < adjacencyList.Length; i++)
        {
            foreach (var neighborValue in adjacencyList[i])
            {
                nodes[i].neighbors.Add(nodes[neighborValue - 1]);
            }
        }

        return nodes[0];
    }

    public static int[][] ToAdjacencyList(Node? node)
    {
        if (node is null)
        {
            return [];
        }

        var nodes = GetReachableNodesByValue(node);
        var result = new int[nodes.Count][];

        for (var i = 0; i < nodes.Count; i++)
        {
            result[i] = nodes[i].neighbors.Select(neighbor => neighbor.val).ToArray();
        }

        return result;
    }

    public static bool HasSharedReference(Node? original, Node? clone)
    {
        if (original is null || clone is null)
        {
            return original == clone;
        }

        var originalNodes = GetReachableNodesByReference(original);
        var cloneNodes = GetReachableNodesByReference(clone);

        return cloneNodes.Any(originalNodes.Contains);
    }

    private static List<Node> GetReachableNodesByValue(Node node)
    {
        var visited = new Dictionary<int, Node>();
        var queue = new Queue<Node>();

        visited[node.val] = node;
        queue.Enqueue(node);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            foreach (var neighbor in current.neighbors)
            {
                if (visited.ContainsKey(neighbor.val))
                {
                    continue;
                }

                visited[neighbor.val] = neighbor;
                queue.Enqueue(neighbor);
            }
        }

        return visited.OrderBy(pair => pair.Key).Select(pair => pair.Value).ToList();
    }

    private static HashSet<Node> GetReachableNodesByReference(Node node)
    {
        var visited = new HashSet<Node>();
        var queue = new Queue<Node>();

        visited.Add(node);
        queue.Enqueue(node);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            foreach (var neighbor in current.neighbors)
            {
                if (visited.Add(neighbor))
                {
                    queue.Enqueue(neighbor);
                }
            }
        }

        return visited;
    }
}
