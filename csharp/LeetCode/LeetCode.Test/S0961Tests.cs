using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S0961Tests
    {
        [Fact]
        public void RepeatedNTimes_ReturnsExpectedValue_ForFirstExample()
        {
            var result = new S0961().RepeatedNTimes([1, 2, 3, 3]);
            Assert.Equal(3, result);
        }

        [Fact]
        public void RepeatedNTimes_ReturnsExpectedValue_ForSecondExample()
        {
            var result = new S0961().RepeatedNTimes([2, 1, 2, 5, 3, 2]);
            Assert.Equal(2, result);
        }

        [Fact]
        public void RepeatedNTimes_ReturnsExpectedValue_ForThirdExample()
        {
            var result = new S0961().RepeatedNTimes([5, 1, 5, 2, 5, 3, 5, 4]);
            Assert.Equal(5, result);
        }
    }
}
