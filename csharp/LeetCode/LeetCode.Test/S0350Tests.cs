using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S0350Tests
    {
        [Fact]
        public void Intersect_ReturnsExpectedIntersection_ForFirstExample()
        {
            var result = new S0350().Intersect([1, 2, 2, 1], [2, 2]);

            Assert.Equal([2, 2], result);
        }

        [Fact]
        public void Intersect_ReturnsExpectedIntersection_ForSecondExample()
        {
            var result = new S0350().Intersect([4, 9, 5], [9, 4, 9, 8, 4]);

            Assert.Equal(2, result.Length);
            Assert.Contains(4, result);
            Assert.Contains(9, result);
        }

        [Fact]
        public void Intersect_ReturnsEmptyArray_WhenThereIsNoIntersection()
        {
            var result = new S0350().Intersect([1, 3, 5], [2, 4, 6]);

            Assert.Empty(result);
        }
    }
}
