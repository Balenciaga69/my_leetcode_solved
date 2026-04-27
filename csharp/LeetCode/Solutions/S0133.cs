// TODO:
// 題目：給定連通無向圖任一節點，回傳此圖的深拷貝。
using LeetCode.Utilities;

namespace LeetCode.Solutions;

public class S0133
{
    private const Method ActiveMethod = Method.DfsHashMap;

    private enum Method
    {
        DfsHashMap,
        BfsHashMap
    }

    /*
     * 主方法只負責切換目前採用的解法。
     * 預設使用 DFS 搭配 Dictionary<原節點, 複製節點>，避免無向圖循環造成無限遞迴。
     * 圖中每個節點與邊各處理一次，時間 O(V + E)。
     */
    public Node? CloneGraph(Node? node)
    {
        return ActiveMethod switch
        {
            Method.DfsHashMap => CloneGraph_DfsHashMap(node),
            Method.BfsHashMap => CloneGraph_BfsHashMap(node),
            _ => throw new InvalidOperationException("Unknown solution method.")
        };
    }

    /*
     * DFS 進入節點時先檢查是否已建立 clone。
     * 若沒有，就先建立 clone 並放入 map，再遞迴複製所有鄰居。
     * 先放入 map 是處理 cycle 的關鍵。
     */
    public Node? CloneGraph_DfsHashMap(Node? node) // __DFS遞迴HashMap法
    {
        return Clone(node, new Dictionary<Node, Node>());
    }

    /*
     * BFS 用 queue 展開原圖節點。
     * map 保存每個原節點對應的 clone；遇到新鄰居時先建立 clone 並入隊。
     * 每處理一條鄰接關係，就把 clone 鄰居加入目前 clone 的 neighbors。
     */
    public Node? CloneGraph_BfsHashMap(Node? node) // __BFS佇列HashMap法
    {
        if (node is null)
        {
            return null;
        }

        var clones = new Dictionary<Node, Node>
        {
            [node] = new Node(node.val)
        };
        var queue = new Queue<Node>();
        queue.Enqueue(node);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            foreach (var neighbor in current.neighbors)
            {
                if (!clones.ContainsKey(neighbor))
                {
                    clones[neighbor] = new Node(neighbor.val);
                    queue.Enqueue(neighbor);
                }

                clones[current].neighbors.Add(clones[neighbor]);
            }
        }

        return clones[node];
    }

    private static Node? Clone(Node? node, Dictionary<Node, Node> clones)
    {
        if (node is null)
        {
            return null;
        }

        if (clones.TryGetValue(node, out var existingClone))
        {
            return existingClone;
        }

        var clone = new Node(node.val);
        clones[node] = clone;

        foreach (var neighbor in node.neighbors)
        {
            clone.neighbors.Add(Clone(neighbor, clones)!);
        }

        return clone;
    }
}
