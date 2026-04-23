using LeetCode.Solutions;

namespace LeetCode.Test
{
    public class S0942Tests
    {
        [Fact]
        public void DiStringMatch_ReturnsExpectedPermutation_ForFirstExample()
        {
            var result = new S0942().DiStringMatch("IDID");
            Assert.Equal([0, 4, 1, 3, 2], result);
        }

        [Fact]
        public void DiStringMatch_ReturnsExpectedPermutation_ForSecondExample()
        {
            var result = new S0942().DiStringMatch("III");
            Assert.Equal([0, 1, 2, 3], result);
        }

        [Fact]
        public void DiStringMatch_ReturnsExpectedPermutation_ForThirdExample()
        {
            var result = new S0942().DiStringMatch("DDI");
            Assert.Equal([3, 2, 0, 1], result);
        }
    }
}
