using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S0209Tests
    {
        [Fact]
        public void MinSubArrayLen_ReturnsExpectedLength_ForFirstExample()
        {
            var result = new S0209().MinSubArrayLen(7, [2, 3, 1, 2, 4, 3]);
            Assert.Equal(2, result);
        }

        [Fact]
        public void MinSubArrayLen_ReturnsOne_WhenSingleElementMeetsTarget()
        {
            var result = new S0209().MinSubArrayLen(4, [1, 4, 4]);
            Assert.Equal(1, result);
        }

        [Fact]
        public void MinSubArrayLen_ReturnsZero_WhenNoSubarrayMeetsTarget()
        {
            var result = new S0209().MinSubArrayLen(11, [1, 1, 1, 1, 1, 1, 1, 1]);
            Assert.Equal(0, result);
        }
    }
}
