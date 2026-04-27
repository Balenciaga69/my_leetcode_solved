using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S0238Tests
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 })]
        [InlineData(new[] { -1, 1, 0, -3, 3 }, new[] { 0, 0, 9, 0, 0 })]
        [InlineData(new[] { 0, 0 }, new[] { 0, 0 })]
        [InlineData(new[] { 2, 3 }, new[] { 3, 2 })]
        public void ProductExceptSelf_ReturnsExpectedArray(int[] nums, int[] expected)
        {
            var result = new S0238().ProductExceptSelf(nums);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ProductExceptSelf_AllMethodsReturnSameResult()
        {
            var solution = new S0238();
            int[] nums = [2, 3, 4, 5];

            Assert.Equal([60, 40, 30, 24], solution.ProductExceptSelf_OutputPrefixSuffix(nums));
            Assert.Equal([60, 40, 30, 24], solution.ProductExceptSelf_PrefixSuffixArrays(nums));
        }
    }
}
