using LeetCode.Solutions;
namespace LeetCode.Test
{
    public class S0014Tests
    {
        [Fact]
        public void LongestCommonPrefix_ReturnsExpectedPrefix()
        {
            var result = new S0014().LongestCommonPrefix(["flower", "flow", "flight"]);
            Assert.Equal("fl", result);
        }
        [Fact]
        public void LongestCommonPrefix_ReturnsEmptyString_WhenNoCommonPrefix()
        {
            var result = new S0014().LongestCommonPrefix(["dog", "racecar", "car"]);
            Assert.Equal(string.Empty, result);
        }
        [Fact]
        public void LongestCommonPrefix_ReturnsWholeString_WhenAllStringsMatch()
        {
            var result = new S0014().LongestCommonPrefix(["same", "same", "same"]);
            Assert.Equal("same", result);
        }
    }
}
