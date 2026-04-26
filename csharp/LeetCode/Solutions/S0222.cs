using LeetCode.Utilities;
//TODO:
namespace LeetCode.Solutions;
public class S0222
{
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