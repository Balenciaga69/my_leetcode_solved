using LeetCode.Solutions;
using LeetCode.Utilities;

namespace LeetCode.Test
{
    public class S0235Tests
    {
        [Theory]
        [InlineData(2, 8, 6)]
        [InlineData(2, 4, 2)]
        [InlineData(3, 5, 4)]
        public void LowestCommonAncestor_ReturnsExpectedNode(int pValue, int qValue, int expected)
        {
            var root = TreeBuilder.FromLevelOrder([6, 2, 8, 0, 4, 7, 9, null, null, 3, 5]);
            var p = TreeBuilder.FindByValue(root, pValue);
            var q = TreeBuilder.FindByValue(root, qValue);

            var result = new S0235().LowestCommonAncestor(root, p, q);

            Assert.Equal(expected, result?.val);
        }

        [Fact]
        public void LowestCommonAncestor_AllMethodsReturnSameNode()
        {
            var root = TreeBuilder.FromLevelOrder([2, 1]);
            var p = TreeBuilder.FindByValue(root, 2);
            var q = TreeBuilder.FindByValue(root, 1);
            var solution = new S0235();

            Assert.Equal(2, solution.LowestCommonAncestor_IterativeBst(root, p, q)?.val);
            Assert.Equal(2, solution.LowestCommonAncestor_RecursiveBst(root, p, q)?.val);
        }
    }
}
