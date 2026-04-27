// TODO:
// 題目：給定 BST root 與 k，回傳第 k 小的節點值。
using LeetCode.Utilities;

namespace LeetCode.Solutions;

public class S0230
{
    private const Method ActiveMethod = Method.IterativeInorder;

    private enum Method
    {
        IterativeInorder,
        RecursiveInorder
    }

    /*
     * 主方法只負責切換目前採用的解法。
     * 預設使用 BST 的中序遍歷會得到遞增序列這個性質。
     * 走到第 k 個節點就立即回傳，不需要遍歷完整棵樹。
     */
    public int KthSmallest(TreeNode? root, int k)
    {
        return ActiveMethod switch
        {
            Method.IterativeInorder => KthSmallest_IterativeInorder(root, k),
            Method.RecursiveInorder => KthSmallest_RecursiveInorder(root, k),
            _ => throw new InvalidOperationException("Unknown solution method.")
        };
    }

    /*
     * 用 stack 模擬中序遍歷：一路往左入棧，彈出時代表下一個最小節點。
     * 每彈出一個節點就遞減 k，k 歸零時該節點就是答案。
     * 避免遞迴呼叫堆疊，適合較深的樹。
     */
    public int KthSmallest_IterativeInorder(TreeNode? root, int k) // __迭代中序走訪法
    {
        var stack = new Stack<TreeNode>();
        var current = root;

        while (current is not null || stack.Count > 0)
        {
            while (current is not null)
            {
                stack.Push(current);
                current = current.left;
            }

            current = stack.Pop();
            k--;

            if (k == 0)
            {
                return current.val;
            }

            current = current.right;
        }

        throw new ArgumentOutOfRangeException(nameof(k));
    }

    /*
     * 遞迴做 left-root-right 中序遍歷。
     * 用 remaining 記錄還需要跳過幾個節點，找到答案後停止後續遞迴。
     * 寫法簡潔，但樹很深時會受限於呼叫堆疊。
     */
    public int KthSmallest_RecursiveInorder(TreeNode? root, int k) // __遞迴中序走訪法
    {
        var remaining = k;
        var answer = 0;

        void Traverse(TreeNode? node)
        {
            if (node is null || remaining == 0)
            {
                return;
            }

            Traverse(node.left);

            if (--remaining == 0)
            {
                answer = node.val;
                return;
            }

            Traverse(node.right);
        }

        Traverse(root);
        return answer;
    }
}
