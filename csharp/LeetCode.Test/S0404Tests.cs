using LeetCode.Solutions;
using LeetCode.Utilities;
namespace LeetCode.Test
{
    public class S0404Tests
    {
        [Fact]
        public void SumOfLeftLeaves_ReturnsExpectedSum_ForFirstExample()
        {
            var root = TreeBuilder.FromLevelOrder([3, 9, 20, null, null, 15, 7]);
            var result = new S0404().SumOfLeftLeaves(root);
            Assert.Equal(24, result);
        }
        [Fact]
        public void SumOfLeftLeaves_ReturnsZero_WhenTreeHasSingleNode()
        {
            var root = TreeBuilder.FromLevelOrder([1]);
            var result = new S0404().SumOfLeftLeaves(root);
            Assert.Equal(0, result);
        }
        [Fact]
        public void SumOfLeftLeaves_ReturnsZero_WhenThereAreNoLeftLeaves()
        {
            var root = TreeBuilder.FromLevelOrder([1, null, 2, null, 3]);
            var result = new S0404().SumOfLeftLeaves(root);
            Assert.Equal(0, result);
        }
    }
}
