using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S0944Tests
    {
        [Fact]
        public void MinDeletionSize_ReturnsExpectedCount_ForFirstExample()
        {
            var result = new S0944().MinDeletionSize(["cba", "daf", "ghi"]);
            Assert.Equal(1, result);
        }

        [Fact]
        public void MinDeletionSize_ReturnsZero_WhenSingleColumnIsSorted()
        {
            var result = new S0944().MinDeletionSize(["a", "b"]);
            Assert.Equal(0, result);
        }

        [Fact]
        public void MinDeletionSize_ReturnsAllColumns_WhenAllAreUnsorted()
        {
            var result = new S0944().MinDeletionSize(["zyx", "wvu", "tsr"]);
            Assert.Equal(3, result);
        }
    }
}
