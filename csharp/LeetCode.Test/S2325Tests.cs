using LeetCode.Solutions;
namespace LeetCode.Test
{
    public class S2325Tests
    {
        [Fact]
        public void DecodeMessage_ReturnsExpectedMessage_ForFirstExample()
        {
            var key = "the quick brown fox jumps over the lazy dog";
            var message = "vkbs bs t suepuv";
            var result = new S2325().DecodeMessage(key, message);
            Assert.Equal("this is a secret", result);
        }
        [Fact]
        public void DecodeMessage_ReturnsExpectedMessage_ForSecondExample()
        {
            var key = "eljuxhpwnyrdgtqkviszcfmabo";
            var message = "zwx hnfx lqantp mnoeius ycgk vcnjrdb";
            var result = new S2325().DecodeMessage(key, message);
            Assert.Equal("the five boxing wizards jump quickly", result);
        }
        [Fact]
        public void DecodeMessage_KeepsSpacesUnchanged()
        {
            var key = "abcdefghijklmnopqrstuvwxyz";
            var message = "a b c";
            var result = new S2325().DecodeMessage(key, message);
            Assert.Equal("a b c", result);
        }
    }
}
