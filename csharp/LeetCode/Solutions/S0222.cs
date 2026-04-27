// 題目：給定一棵完全二元樹 root，計算樹中節點總數；要求使用比 O(n) 更好的演算法。
using LeetCode.Utilities;
//TODO:
namespace LeetCode.Solutions;
public class S0222
{
    /*
     * 完全二元樹若最左高度等於最右高度，代表這棵子樹是滿二元樹，可直接用 2^h - 1 計算。
     * 若高度不同，遞迴計算左右子樹節點數。
     * 每層只走左右邊界高度，時間約 O(log^2 n)，優於一般 DFS 的 O(n)。
     */
    public int CountNodes(TreeNode? root)
    {
        if (root is null) return 0;
        var lh = 1;
        var lNode = root.left;
        while (lNode is not null)
        {
            lh++;
            lNode = lNode.left;
        }
        var rh = 1;
        var rNode = root.right;
        while (rNode is not null)
        {
            rh++;
            rNode = rNode.right;
        }
        if (rh == lh)
        {
            return (int)Math.Pow(2, rh) - 1;
        }
        else
        {
            return 1 + CountNodes(root.left) + CountNodes(root.right);
        }
    }
}
// public int CountNodes(TreeNode? root)
// {
//     if (root is null) return 0;
//     var leftHeight = GetHeight(root.left);
//     var rightHeight = GetHeight(root.right);
//     if (leftHeight == rightHeight)
//     {
//         return (1 << leftHeight) + CountNodes(root.right);
//     }
//     return (1 << rightHeight) + CountNodes(root.left);
// }
// private static int GetHeight(TreeNode? node)
// {
//     var height = 0;
//     while (node is not null)
//     {
//         height++;
//         node = node.left;
//     }
//     return height;
// }
