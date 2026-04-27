using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S0128Tests
    {
        [Theory]
        [InlineData(new[] { 100, 4, 200, 1, 3, 2 }, 4)]
        [InlineData(new[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }, 9)]
        [InlineData(new[] { 1, 0, 1, 2 }, 3)]
        [InlineData(new int[] { }, 0)]
        [InlineData(new[] { -2, -3, -1, 5, 6 }, 3)]
        public void LongestConsecutive_ReturnsExpectedLength(int[] nums, int expected)
        {
            var result = new S0128().LongestConsecutive(nums);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void LongestConsecutive_AllMethodsReturnSameResult()
        {
            var solution = new S0128();
            int[] nums = [9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6];

            Assert.Equal(7, solution.LongestConsecutive_HashSetStartScan(nums));
            Assert.Equal(7, solution.LongestConsecutive_HashSetRemoveExpand(nums));
        }
    }
}
