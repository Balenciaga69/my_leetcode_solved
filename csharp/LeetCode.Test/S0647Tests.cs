using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S0647Tests
    {
        [Theory]
        [InlineData("abc", 3)]
        [InlineData("aaa", 6)]
        [InlineData("abccba", 9)]
        [InlineData("racecar", 10)]
        public void CountSubstrings_ReturnsExpectedCount(string s, int expected)
        {
            var result = new S0647().CountSubstrings(s);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CountSubstrings_AllMethodsReturnSameResult()
        {
            var solution = new S0647();
            var s = "aaaab";

            Assert.Equal(11, solution.CountSubstrings_ExpandAroundCenter(s));
            Assert.Equal(11, solution.CountSubstrings_DynamicProgramming(s));
        }
    }
}
