using LeetCode.Solutions;
namespace LeetCode.Test
{
    public class S2240Tests
    {
        [Fact]
        public void WaysToBuyPensPencils_ReturnsExpectedWays_ForFirstExample()
        {
            var result = new S2240().WaysToBuyPensPencils(20, 10, 5);
            Assert.Equal(9, result);
        }
        [Fact]
        public void WaysToBuyPensPencils_ReturnsOne_WhenNeitherItemIsAffordable()
        {
            var result = new S2240().WaysToBuyPensPencils(5, 10, 10);
            Assert.Equal(1, result);
        }
        [Fact]
        public void WaysToBuyPensPencils_ReturnsAllPencilOptions_WhenPenIsTooExpensive()
        {
            var result = new S2240().WaysToBuyPensPencils(7, 100, 2);
            Assert.Equal(4, result);
        }
    }
}
