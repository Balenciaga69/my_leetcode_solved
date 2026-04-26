using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S0819Tests
    {
        [Fact]
        public void MostCommonWord_ReturnsExpectedWord_ForFirstExample()
        {
            var paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            string[] banned = ["hit"];

            var result = new S0819().MostCommonWord(paragraph, banned);

            Assert.Equal("ball", result);
        }

        [Fact]
        public void MostCommonWord_ReturnsExpectedWord_ForSecondExample()
        {
            var paragraph = "a.";
            string[] banned = [];

            var result = new S0819().MostCommonWord(paragraph, banned);

            Assert.Equal("a", result);
        }

        [Fact]
        public void MostCommonWord_IgnoresPunctuationAndCase()
        {
            var paragraph = "A, a! a?";
            string[] banned = ["b"];

            var result = new S0819().MostCommonWord(paragraph, banned);

            Assert.Equal("a", result);
        }
    }
}
