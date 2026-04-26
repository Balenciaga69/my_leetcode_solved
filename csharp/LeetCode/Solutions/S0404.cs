// 題目：給定二元樹 root，計算所有左葉節點的值總和；左葉節點是父節點的左子節點且本身沒有子節點。
using LeetCode.Utilities;
namespace LeetCode.Solutions;
public class S0404
{
    public record QItem(TreeNode node, bool isLeft);
    public int SumOfLeftLeaves(TreeNode? root)
    {
        if (root is null) return 0;
        var result = 0;
        var queue = new Queue<QItem>();
        queue.Enqueue(new(root, false));
        while (queue.Count > 0)
        {
            var item = queue.Dequeue();
            var node = item.node;
            if (node.left is not null) queue.Enqueue(new(node.left, true));
            if (node.right is not null) queue.Enqueue(new(node.right, false));
            if (node.left is null && node.right is null && item.isLeft)
            {
                result += node.val;
            }
        }
        return result;
    }
}
