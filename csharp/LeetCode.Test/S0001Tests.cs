using LeetCode.Solutions;
namespace LeetCode.Test
{
    public class S0001Tests
    {
        [Fact]
        public void TwoSum_ReturnsExpectedIndexes()
        {
            var result = new S0001().TwoSum([2, 7, 11, 15], 9);
            Assert.Equal([0, 1], result);
        }
        [Fact]
        public void TwoSum_ReturnsExpectedIndexes_WhenPairIsLater()
        {
            var result = new S0001().TwoSum([3, 2, 4], 6);
            Assert.Equal([1, 2], result);
        }
    }
}
