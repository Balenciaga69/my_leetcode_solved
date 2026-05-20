using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S0322Tests
    {
        [Theory]
        [InlineData(new[] { 1, 2, 5 }, 11, 3)]
        [InlineData(new[] { 2 }, 3, -1)]
        [InlineData(new[] { 1 }, 0, 0)]
        [InlineData(new[] { 1 }, 2, 2)]
        [InlineData(new[] { 2, 5, 10, 1 }, 27, 4)]
        public void CoinChange_ReturnsExpectedResult(int[] coins, int amount, int expected)
        {
            var result = new S0322().CoinChange(coins, amount);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CoinChange_AllMethodsReturnSameResult()
        {
            var solution = new S0322();

            Assert.Equal(3, solution.CoinChange_DynamicProgrammingBottomUp(new[] { 1, 2, 5 }, 11));
            Assert.Equal(3, solution.CoinChange_DynamicProgrammingCompleteKnapsack(new[] { 1, 2, 5 }, 11));
            Assert.Equal(3, solution.CoinChange_BreadthFirstSearch(new[] { 1, 2, 5 }, 11));
        }
    }
}
