// TODO:
// 題目：給定二元樹 preorder 與 inorder traversal，重建並回傳原二元樹。
using LeetCode.Utilities;

namespace LeetCode.Solutions;

public class S0105
{
    private const Method ActiveMethod = Method.RecursiveIndexMap;

    private enum Method
    {
        RecursiveIndexMap,
        RecursiveSlicing
    }

    /*
     * 主方法只負責切換目前採用的解法。
     * 預設使用 preorder 指針加 inorder 索引表，避免每次切陣列造成額外成本。
     * 時間 O(n)，空間 O(n)。
     */
    public TreeNode? BuildTree(int[] preorder, int[] inorder)
    {
        return ActiveMethod switch
        {
            Method.RecursiveIndexMap => BuildTree_RecursiveIndexMap(preorder, inorder),
            Method.RecursiveSlicing => BuildTree_RecursiveSlicing(preorder, inorder),
            _ => throw new InvalidOperationException("Unknown solution method.")
        };
    }

    /*
     * preorder 的下一個值一定是目前子樹根節點。
     * 用 inorder 索引表快速找根節點位置，左側是左子樹、右側是右子樹。
     * 遞迴只傳左右邊界，不複製陣列，因此效率最好。
     */
    public TreeNode? BuildTree_RecursiveIndexMap(int[] preorder, int[] inorder) // __遞迴索引表法
    {
        var inorderIndexByValue = new Dictionary<int, int>();

        for (var i = 0; i < inorder.Length; i++)
        {
            inorderIndexByValue[inorder[i]] = i;
        }

        var preorderIndex = 0;

        TreeNode? Build(int left, int right)
        {
            if (left > right)
            {
                return null;
            }

            var rootValue = preorder[preorderIndex++];
            var root = new TreeNode(rootValue);
            var inorderIndex = inorderIndexByValue[rootValue];

            root.left = Build(left, inorderIndex - 1);
            root.right = Build(inorderIndex + 1, right);

            return root;
        }

        return Build(0, inorder.Length - 1);
    }

    /*
     * 每次從 preorder[0] 取根節點，再用 inorder 找左右子樹範圍。
     * 直接切出子陣列遞迴，概念清楚但會產生大量陣列複製。
     * 適合理解題意，不適合大輸入最佳化。
     */
    public TreeNode? BuildTree_RecursiveSlicing(int[] preorder, int[] inorder) // __遞迴切分法
    {
        if (preorder.Length == 0)
        {
            return null;
        }

        var rootValue = preorder[0];
        var root = new TreeNode(rootValue);
        var inorderRootIndex = Array.IndexOf(inorder, rootValue);

        root.left = BuildTree_RecursiveSlicing(
            preorder[1..(inorderRootIndex + 1)],
            inorder[..inorderRootIndex]);

        root.right = BuildTree_RecursiveSlicing(
            preorder[(inorderRootIndex + 1)..],
            inorder[(inorderRootIndex + 1)..]);

        return root;
    }
}
