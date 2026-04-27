using LeetCode.Solutions;
using LeetCode.Utilities;

namespace LeetCode.Test
{
    public class S0019Tests
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 2, new[] { 1, 2, 3, 5 })]
        [InlineData(new[] { 1 }, 1, new int[] { })]
        [InlineData(new[] { 1, 2 }, 1, new[] { 1 })]
        [InlineData(new[] { 1, 2 }, 2, new[] { 2 })]
        public void RemoveNthFromEnd_ReturnsExpectedList(int[] values, int n, int[] expected)
        {
            var head = ListBuilder.FromArray(values);

            var result = new S0019().RemoveNthFromEnd(head, n);

            Assert.Equal(expected, ListBuilder.ToArray(result));
        }

        [Fact]
        public void RemoveNthFromEnd_AllMethodsReturnSameResult()
        {
            var solution = new S0019();

            var onePass = solution.RemoveNthFromEnd_OnePassTwoPointers(ListBuilder.FromArray([1, 2, 3, 4, 5]), 3);
            var twoPass = solution.RemoveNthFromEnd_TwoPassLength(ListBuilder.FromArray([1, 2, 3, 4, 5]), 3);

            Assert.Equal([1, 2, 4, 5], ListBuilder.ToArray(onePass));
            Assert.Equal([1, 2, 4, 5], ListBuilder.ToArray(twoPass));
        }
    }
}
