namespace Csharp.Structure
{
    public class TreeNode
    {
        public int Val;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.Val = val;
            this.Left = left;
            this.Right = right;
        }
    }
}