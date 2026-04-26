using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S1991Tests
    {
        [Fact]
        public void FindMiddleIndex_ReturnsExpectedIndex_ForFirstExample()
        {
            var result = new S1991().FindMiddleIndex([2, 3, -1, 8, 4]);
            Assert.Equal(3, result);
        }

        [Fact]
        public void FindMiddleIndex_ReturnsExpectedIndex_ForSecondExample()
        {
            var result = new S1991().FindMiddleIndex([1, -1, 4]);
            Assert.Equal(2, result);
        }

        [Fact]
        public void FindMiddleIndex_ReturnsMinusOne_WhenNoMiddleIndexExists()
        {
            var result = new S1991().FindMiddleIndex([2, 5]);
            Assert.Equal(-1, result);
        }
    }
}
