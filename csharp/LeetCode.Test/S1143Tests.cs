using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S1143Tests
    {
        [Theory]
        [InlineData("abcde", "ace", 3)]
        [InlineData("abc", "abc", 3)]
        [InlineData("abc", "def", 0)]
        [InlineData("bsbininm", "jmjkbkjkv", 1)]
        public void LongestCommonSubsequence_ReturnsExpectedLength(string text1, string text2, int expected)
        {
            var result = new S1143().LongestCommonSubsequence(text1, text2);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void LongestCommonSubsequence_AllMethodsReturnSameResult()
        {
            var solution = new S1143();

            Assert.Equal(5, solution.LongestCommonSubsequence_DynamicProgramming1D("abcba", "abcbcba"));
            Assert.Equal(5, solution.LongestCommonSubsequence_DynamicProgramming2D("abcba", "abcbcba"));
        }
    }
}
