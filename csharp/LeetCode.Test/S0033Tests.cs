using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S0033Tests
    {
        [Theory]
        [InlineData(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
        [InlineData(new[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
        [InlineData(new[] { 1 }, 0, -1)]
        [InlineData(new[] { 1 }, 1, 0)]
        [InlineData(new[] { 3, 1 }, 1, 1)]
        public void Search_ReturnsExpectedIndex(int[] nums, int target, int expected)
        {
            var result = new S0033().Search(nums, target);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Search_AllMethodsReturnSameResult()
        {
            var solution = new S0033();
            int[] nums = [6, 7, 8, 1, 2, 3, 4, 5];

            Assert.Equal(5, solution.Search_OnePassBinarySearch(nums, 3));
            Assert.Equal(5, solution.Search_FindPivotThenBinarySearch(nums, 3));
        }
    }
}
