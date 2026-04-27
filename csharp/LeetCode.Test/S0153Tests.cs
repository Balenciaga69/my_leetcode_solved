using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S0153Tests
    {
        [Theory]
        [InlineData(new[] { 3, 4, 5, 1, 2 }, 1)]
        [InlineData(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0)]
        [InlineData(new[] { 11, 13, 15, 17 }, 11)]
        [InlineData(new[] { 1 }, 1)]
        [InlineData(new[] { 2, 1 }, 1)]
        public void FindMin_ReturnsExpectedMinimum(int[] nums, int expected)
        {
            var result = new S0153().FindMin(nums);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FindMin_AllMethodsReturnSameResult()
        {
            var solution = new S0153();
            int[] nums = [5, 6, 7, 1, 2, 3, 4];

            Assert.Equal(1, solution.FindMin_BinarySearchRightCompare(nums));
            Assert.Equal(1, solution.FindMin_BinarySearchFindPivot(nums));
        }
    }
}
