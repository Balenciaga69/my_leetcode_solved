using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S1995Tests
    {
        [Fact]
        public void CountQuadruplets_ReturnsExpectedCount_ForFirstExample()
        {
            var result = new S1995().CountQuadruplets([1, 2, 3, 6]);
            Assert.Equal(1, result);
        }

        [Fact]
        public void CountQuadruplets_ReturnsZero_WhenNoQuadrupletsExist()
        {
            var result = new S1995().CountQuadruplets([3, 3, 6, 4, 5]);
            Assert.Equal(0, result);
        }

        [Fact]
        public void CountQuadruplets_ReturnsExpectedCount_ForThirdExample()
        {
            var result = new S1995().CountQuadruplets([1, 1, 1, 3, 5]);
            Assert.Equal(4, result);
        }
    }
}
