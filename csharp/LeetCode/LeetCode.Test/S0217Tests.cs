using LeetCode.Solutions;
namespace LeetCode.Test
{
    public class S0217Tests
    {
        [Fact]
        public void ContainsDuplicate_ReturnsTrue_WhenDuplicateExists()
        {
            var result = new S0217().ContainsDuplicate([1, 2, 3, 1]);
            Assert.True(result);
        }
        [Fact]
        public void ContainsDuplicate_ReturnsFalse_WhenAllValuesAreDistinct()
        {
            var result = new S0217().ContainsDuplicate([1, 2, 3, 4]);
            Assert.False(result);
        }
        [Fact]
        public void ContainsDuplicate_ReturnsTrue_WhenMultipleDuplicatesExist()
        {
            var result = new S0217().ContainsDuplicate([1, 1, 1, 3, 3, 4, 3, 2, 4, 2]);
            Assert.True(result);
        }
        [Fact]
        public void ContainsDuplicate_ReturnsFalse_WhenSingleElementArray()
        {
            var result = new S0217().ContainsDuplicate([42]);
            Assert.False(result);
        }
    }
}
