using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S2006Tests
    {
        [Fact]
        public void CountKDifference_ReturnsExpectedCount_ForFirstExample()
        {
            var result = new S2006().CountKDifference([1, 2, 2, 1], 1);
            Assert.Equal(4, result);
        }

        [Fact]
        public void CountKDifference_ReturnsZero_WhenNoPairsExist()
        {
            var result = new S2006().CountKDifference([1, 3], 3);
            Assert.Equal(0, result);
        }

        [Fact]
        public void CountKDifference_ReturnsExpectedCount_ForThirdExample()
        {
            var result = new S2006().CountKDifference([3, 2, 1, 5, 4], 2);
            Assert.Equal(3, result);
        }
    }
}
