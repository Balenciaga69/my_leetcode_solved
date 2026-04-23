namespace LeetCode.Utilities;
public static class TreeBuilder
{
    public static TreeNode? FromLevelOrder(int?[] values)
    {
        // 沒有資料或根節點是 null 時，直接回傳空樹。
        if (values.Length == 0 || values[0] is null) return null;
        // 先建立根節點，作為層序建樹的起點。
        var root = new TreeNode(values[0]!.Value);
        // 用佇列保存目前還沒展開左右子節點的節點。
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        // 從第二個元素開始處理，因為第 0 個元素已經用來建立 root。
        var i = 1;
        while (queue.Count > 0 && i < values.Length)
        {
            // 取出目前要補左右子節點的父節點。
            var node = queue.Dequeue();
            // 如果下一個值存在且不是 null，就建立左子節點。
            if (i < values.Length && values[i] is int leftValue)
            {
                node.left = new TreeNode(leftValue);
                // 左子節點建立後，也放進佇列，之後輪到它繼續接子節點。
                queue.Enqueue(node.left);
            }
            // 左子節點的值已經讀取完，索引往前移。
            i++;
            // 如果下一個值存在且不是 null，就建立右子節點。
            if (i < values.Length && values[i] is int rightValue)
            {
                node.right = new TreeNode(rightValue);
                // 右子節點建立後，也放進佇列，之後輪到它繼續接子節點。
                queue.Enqueue(node.right);
            }
            // 右子節點的值已經讀取完，索引往前移。
            i++;
        }
        // 回傳整棵建好的樹。
        return root;
    }
}
