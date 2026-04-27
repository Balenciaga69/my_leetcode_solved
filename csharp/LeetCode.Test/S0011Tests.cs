using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S0011Tests
    {
        [Theory]
        [InlineData(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        [InlineData(new[] { 1, 1 }, 1)]
        [InlineData(new[] { 4, 3, 2, 1, 4 }, 16)]
        [InlineData(new[] { 1, 2, 1 }, 2)]
        public void MaxArea_ReturnsExpectedArea(int[] height, int expected)
        {
            var result = new S0011().MaxArea(height);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void MaxArea_AllMethodsReturnSameResult()
        {
            var solution = new S0011();
            int[] height = [2, 3, 4, 5, 18, 17, 6];

            Assert.Equal(17, solution.MaxArea_TwoPointers(height));
            Assert.Equal(17, solution.MaxArea_BruteForce(height));
        }
    }
}
