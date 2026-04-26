using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S2032Tests
    {
        [Fact]
        public void TwoOutOfThree_ReturnsExpectedValues_ForFirstExample()
        {
            var result = new S2032().TwoOutOfThree([1, 1, 3, 2], [2, 3], [3]);

            Assert.Equal(2, result.Count);
            Assert.Contains(2, result);
            Assert.Contains(3, result);
        }

        [Fact]
        public void TwoOutOfThree_ReturnsExpectedValues_ForSecondExample()
        {
            var result = new S2032().TwoOutOfThree([3, 1], [2, 3], [1, 2]);

            Assert.Equal(3, result.Count);
            Assert.Contains(1, result);
            Assert.Contains(2, result);
            Assert.Contains(3, result);
        }

        [Fact]
        public void TwoOutOfThree_ReturnsEmptyList_WhenNoValueAppearsInTwoArrays()
        {
            var result = new S2032().TwoOutOfThree([1, 2, 2], [4, 3, 3], [5]);

            Assert.Empty(result);
        }
    }
}
