using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S0003Tests
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData("", 0)]
        [InlineData("dvdf", 3)]
        [InlineData("abba", 2)]
        public void LengthOfLongestSubstring_ReturnsExpectedLength(string s, int expected)
        {
            var result = new S0003().LengthOfLongestSubstring(s);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void LengthOfLongestSubstring_AllMethodsReturnSameResult()
        {
            var solution = new S0003();
            var s = "tmmzuxt";

            Assert.Equal(5, solution.LengthOfLongestSubstring_SlidingWindowLastSeen(s));
            Assert.Equal(5, solution.LengthOfLongestSubstring_SlidingWindowSet(s));
        }
    }
}
