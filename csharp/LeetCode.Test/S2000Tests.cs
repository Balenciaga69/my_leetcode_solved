using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S2000Tests
    {
        [Fact]
        public void ReversePrefix_ReturnsExpectedString_ForFirstExample()
        {
            var result = new S2000().ReversePrefix("abcdefd", 'd');
            Assert.Equal("dcbaefd", result);
        }

        [Fact]
        public void ReversePrefix_ReturnsExpectedString_ForSecondExample()
        {
            var result = new S2000().ReversePrefix("xyxzxe", 'z');
            Assert.Equal("zxyxxe", result);
        }

        [Fact]
        public void ReversePrefix_ReturnsOriginalString_WhenCharacterDoesNotExist()
        {
            var result = new S2000().ReversePrefix("abcd", 'z');
            Assert.Equal("abcd", result);
        }
    }
}
