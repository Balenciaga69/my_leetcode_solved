using LeetCode.Solutions;
namespace LeetCode.Test
{
    public class S0682Tests
    {
        [Fact]
        public void CalPoints_ReturnsExpectedScore_ForFirstExample()
        {
            var result = new S0682().CalPoints(["5", "2", "C", "D", "+"]);
            Assert.Equal(30, result);
        }
        [Fact]
        public void CalPoints_ReturnsExpectedScore_ForSecondExample()
        {
            var result = new S0682().CalPoints(["5", "-2", "4", "C", "D", "9", "+", "+"]);
            Assert.Equal(27, result);
        }
        [Fact]
        public void CalPoints_ReturnsZero_WhenAllScoresAreCanceled()
        {
            var result = new S0682().CalPoints(["1", "C"]);
            Assert.Equal(0, result);
        }
    }
}
