using LeetCode.Solutions;
using LeetCode.Utilities;

namespace LeetCode.Test
{
    public class S0230Tests
    {
        [Fact]
        public void KthSmallest_ReturnsExpectedValue_ForFirstExample()
        {
            var root = TreeBuilder.FromLevelOrder([3, 1, 4, null, 2]);

            var result = new S0230().KthSmallest(root, 1);

            Assert.Equal(1, result);
        }

        [Fact]
        public void KthSmallest_ReturnsExpectedValue_ForSecondExample()
        {
            var root = TreeBuilder.FromLevelOrder([5, 3, 6, 2, 4, null, null, 1]);

            var result = new S0230().KthSmallest(root, 3);

            Assert.Equal(3, result);
        }

        [Fact]
        public void KthSmallest_AllMethodsReturnSameValue()
        {
            var root = TreeBuilder.FromLevelOrder([5, 3, 6, 2, 4, null, null, 1]);
            var solution = new S0230();

            Assert.Equal(4, solution.KthSmallest_IterativeInorder(root, 4));
            Assert.Equal(4, solution.KthSmallest_RecursiveInorder(root, 4));
        }
    }
}
