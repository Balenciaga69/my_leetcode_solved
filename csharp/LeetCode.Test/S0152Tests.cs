using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S0152Tests
    {
        [Theory]
        [InlineData(new[] { 2, 3, -2, 4 }, 6)]
        [InlineData(new[] { -2, 0, -1 }, 0)]
        [InlineData(new[] { -2, 3, -4 }, 24)]
        [InlineData(new[] { 0, 2 }, 2)]
        [InlineData(new[] { -2 }, -2)]
        public void MaxProduct_ReturnsExpectedProduct(int[] nums, int expected)
        {
            var result = new S0152().MaxProduct(nums);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void MaxProduct_AllMethodsReturnSameResult()
        {
            var solution = new S0152();
            int[] nums = [2, -5, -2, -4, 3];

            Assert.Equal(24, solution.MaxProduct_TrackMaxMinProduct(nums));
            Assert.Equal(24, solution.MaxProduct_PrefixSuffix(nums));
        }
    }
}
