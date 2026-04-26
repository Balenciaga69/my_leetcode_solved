using LeetCode.Solutions;
using LeetCode.Utilities;

namespace LeetCode.Test
{
    public class S0222Tests
    {
        [Fact]
        public void CountNodes_ReturnsExpectedCount_ForFirstExample()
        {
            var root = TreeBuilder.FromLevelOrder([1, 2, 3, 4, 5, 6, 7]);

            var result = new S0222().CountNodes(root);

            Assert.Equal(7, result);
        }

        [Fact]
        public void CountNodes_ReturnsZero_WhenTreeIsEmpty()
        {
            var result = new S0222().CountNodes(null);

            Assert.Equal(0, result);
        }

        [Fact]
        public void CountNodes_ReturnsOne_WhenTreeHasSingleNode()
        {
            var root = TreeBuilder.FromLevelOrder([1]);

            var result = new S0222().CountNodes(root);

            Assert.Equal(1, result);
        }
    }
}
