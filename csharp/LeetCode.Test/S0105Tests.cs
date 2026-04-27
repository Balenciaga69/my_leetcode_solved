using LeetCode.Solutions;
using LeetCode.Utilities;

namespace LeetCode.Test
{
    public class S0105Tests
    {
        [Fact]
        public void BuildTree_ReturnsExpectedTree_ForFirstExample()
        {
            var root = new S0105().BuildTree([3, 9, 20, 15, 7], [9, 3, 15, 20, 7]);

            Assert.Equal([3, 9, 20, null, null, 15, 7], TreeBuilder.ToLevelOrder(root));
        }

        [Fact]
        public void BuildTree_ReturnsSingleNode()
        {
            var root = new S0105().BuildTree([-1], [-1]);

            Assert.Equal([-1], TreeBuilder.ToLevelOrder(root));
        }

        [Fact]
        public void BuildTree_AllMethodsReturnSameTree()
        {
            var solution = new S0105();
            int[] preorder = [1, 2, 4, 5, 3];
            int[] inorder = [4, 2, 5, 1, 3];

            Assert.Equal([1, 2, 3, 4, 5], TreeBuilder.ToLevelOrder(solution.BuildTree_RecursiveIndexMap(preorder, inorder)));
            Assert.Equal([1, 2, 3, 4, 5], TreeBuilder.ToLevelOrder(solution.BuildTree_RecursiveSlicing(preorder, inorder)));
        }
    }
}
