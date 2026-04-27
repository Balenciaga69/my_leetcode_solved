// TODO:
// 題目：給定 BST 與其中兩個節點 p、q，找出它們的最低共同祖先。
using LeetCode.Utilities;

namespace LeetCode.Solutions;

public class S0235
{
    private const Method ActiveMethod = Method.IterativeBst;

    private enum Method
    {
        IterativeBst,
        RecursiveBst
    }

    /*
     * 主方法只負責切換目前採用的解法。
     * 預設利用 BST 性質：若 p、q 都小於目前節點，LCA 在左子樹；都大於則在右子樹。
     * 第一個介於兩者之間的節點就是最低共同祖先。
     */
    public TreeNode? LowestCommonAncestor(TreeNode? root, TreeNode? p, TreeNode? q)
    {
        return ActiveMethod switch
        {
            Method.IterativeBst => LowestCommonAncestor_IterativeBst(root, p, q),
            Method.RecursiveBst => LowestCommonAncestor_RecursiveBst(root, p, q),
            _ => throw new InvalidOperationException("Unknown solution method.")
        };
    }

    /*
     * 先取得 p、q 值的 low/high。
     * 從 root 開始往下走：目前值大於 high 往左，小於 low 往右。
     * 當目前值落在 low/high 之間時，代表 p、q 分岔或其中一個就是目前節點。
     */
    public TreeNode? LowestCommonAncestor_IterativeBst(TreeNode? root, TreeNode? p, TreeNode? q) // __BST迭代法
    {
        var current = root;
        var low = Math.Min(p!.val, q!.val);
        var high = Math.Max(p.val, q.val);

        while (current is not null)
        {
            if (current.val > high)
            {
                current = current.left;
            }
            else if (current.val < low)
            {
                current = current.right;
            }
            else
            {
                return current;
            }
        }

        return null;
    }

    /*
     * 遞迴版本與迭代版判斷相同。
     * 目前節點太大就遞迴左子樹，太小就遞迴右子樹。
     * 若不需要再往單側移動，當前節點就是 LCA。
     */
    public TreeNode? LowestCommonAncestor_RecursiveBst(TreeNode? root, TreeNode? p, TreeNode? q) // __BST遞迴法
    {
        if (root is null)
        {
            return null;
        }

        var low = Math.Min(p!.val, q!.val);
        var high = Math.Max(p.val, q.val);

        if (root.val > high)
        {
            return LowestCommonAncestor_RecursiveBst(root.left, p, q);
        }

        if (root.val < low)
        {
            return LowestCommonAncestor_RecursiveBst(root.right, p, q);
        }

        return root;
    }
}
