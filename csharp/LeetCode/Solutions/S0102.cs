// TODO:
// 題目：給定二元樹 root，回傳由上到下、由左到右的層序遍歷結果。
using LeetCode.Utilities;

namespace LeetCode.Solutions;

public class S0102
{
    private const Method ActiveMethod = Method.BfsQueue;

    private enum Method
    {
        BfsQueue,
        DfsByDepth
    }

    /*
     * 主方法只負責切換目前採用的解法。
     * 預設使用 BFS queue，每次處理目前 queue 中固定數量的節點形成一層。
     * 時間 O(n)，空間 O(w)，w 是樹的最大寬度。
     */
    public IList<IList<int>> LevelOrder(TreeNode? root)
    {
        return ActiveMethod switch
        {
            Method.BfsQueue => LevelOrder_BfsQueue(root),
            Method.DfsByDepth => LevelOrder_DfsByDepth(root),
            _ => throw new InvalidOperationException("Unknown solution method.")
        };
    }

    /*
     * 用 queue 從 root 開始逐層展開。
     * 每輪先記錄目前 queue.Count，這些節點剛好是同一層。
     * 處理節點時再把左右子節點放入 queue，供下一層使用。
     */
    public IList<IList<int>> LevelOrder_BfsQueue(TreeNode? root) // __BFS佇列法
    {
        var result = new List<IList<int>>();

        if (root is null)
        {
            return result;
        }

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var levelSize = queue.Count;
            var level = new List<int>();

            for (var i = 0; i < levelSize; i++)
            {
                var node = queue.Dequeue();
                level.Add(node.val);

                if (node.left is not null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right is not null)
                {
                    queue.Enqueue(node.right);
                }
            }

            result.Add(level);
        }

        return result;
    }

    /*
     * 用 DFS 遞迴時攜帶 depth。
     * 第一次抵達某個 depth 就新增一個 level list，之後把該深度節點加入同一層。
     * 可得到與 BFS 相同的輸出，遞迴深度取決於樹高。
     */
    public IList<IList<int>> LevelOrder_DfsByDepth(TreeNode? root) // __DFS深度分層法
    {
        var result = new List<IList<int>>();

        void Dfs(TreeNode? node, int depth)
        {
            if (node is null)
            {
                return;
            }

            if (depth == result.Count)
            {
                result.Add(new List<int>());
            }

            result[depth].Add(node.val);
            Dfs(node.left, depth + 1);
            Dfs(node.right, depth + 1);
        }

        Dfs(root, 0);
        return result;
    }
}
