using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S0941Tests
    {
        [Fact]
        public void ValidMountainArray_ReturnsFalse_WhenArrayIsTooShort()
        {
            var result = new S0941().ValidMountainArray([2, 1]);
            Assert.False(result);
        }

        [Fact]
        public void ValidMountainArray_ReturnsFalse_WhenThereIsAPlateau()
        {
            var result = new S0941().ValidMountainArray([3, 5, 5]);
            Assert.False(result);
        }

        [Fact]
        public void ValidMountainArray_ReturnsTrue_ForValidMountain()
        {
            var result = new S0941().ValidMountainArray([0, 3, 2, 1]);
            Assert.True(result);
        }

        [Fact]
        public void ValidMountainArray_ReturnsFalse_WhenArrayOnlyIncreases()
        {
            var result = new S0941().ValidMountainArray([0, 1, 2, 3]);
            Assert.False(result);
        }
    }
}
