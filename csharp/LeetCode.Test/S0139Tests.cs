using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S0139Tests
    {
        [Theory]
        [InlineData("leetcode", new[] { "leet", "code" }, true)]
        [InlineData("applepenapple", new[] { "apple", "pen" }, true)]
        [InlineData("catsandog", new[] { "cats", "dog", "sand", "and", "cat" }, false)]
        [InlineData("cars", new[] { "car", "ca", "rs" }, true)]
        public void WordBreak_ReturnsExpectedResult(string s, string[] wordDict, bool expected)
        {
            var result = new S0139().WordBreak(s, wordDict);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void WordBreak_AllMethodsReturnSameResult()
        {
            var solution = new S0139();
            var s = "pineapplepenapple";
            string[] wordDict = ["apple", "pen", "applepen", "pine", "pineapple"];

            Assert.True(solution.WordBreak_DynamicProgramming(s, wordDict));
            Assert.True(solution.WordBreak_DfsMemo(s, wordDict));
        }
    }
}
