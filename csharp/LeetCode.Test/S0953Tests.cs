using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S0953Tests
    {
        [Fact]
        public void IsAlienSorted_ReturnsTrue_ForFirstExample()
        {
            string[] words = ["hello", "leetcode"];
            var order = "hlabcdefgijkmnopqrstuvwxyz";

            var result = new S0953().IsAlienSorted(words, order);

            Assert.True(result);
        }

        [Fact]
        public void IsAlienSorted_ReturnsFalse_ForSecondExample()
        {
            string[] words = ["word", "world", "row"];
            var order = "worldabcefghijkmnpqstuvxyz";

            var result = new S0953().IsAlienSorted(words, order);

            Assert.False(result);
        }

        [Fact]
        public void IsAlienSorted_ReturnsFalse_ForPrefixCase()
        {
            string[] words = ["apple", "app"];
            var order = "abcdefghijklmnopqrstuvwxyz";

            var result = new S0953().IsAlienSorted(words, order);

            Assert.False(result);
        }
    }
}
