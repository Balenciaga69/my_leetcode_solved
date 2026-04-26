using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S1984Tests
    {
        [Fact]
        public void MinimumDifference_ReturnsExpectedValue_ForFirstExample()
        {
            var result = new S1984().MinimumDifference([90], 1);
            Assert.Equal(0, result);
        }

        [Fact]
        public void MinimumDifference_ReturnsExpectedValue_ForSecondExample()
        {
            var result = new S1984().MinimumDifference([9, 4, 1, 7], 2);
            Assert.Equal(2, result);
        }

        [Fact]
        public void MinimumDifference_ReturnsExpectedValue_WhenKIsThree()
        {
            var result = new S1984().MinimumDifference([1, 3, 6, 1], 3);
            Assert.Equal(2, result);
        }
    }
}
