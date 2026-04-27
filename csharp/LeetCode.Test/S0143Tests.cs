using LeetCode.Solutions;
using LeetCode.Utilities;

namespace LeetCode.Test
{
    public class S0143Tests
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 4, 2, 3 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 5, 2, 4, 3 })]
        [InlineData(new[] { 1 }, new[] { 1 })]
        [InlineData(new[] { 1, 2 }, new[] { 1, 2 })]
        public void ReorderList_ReordersInPlace(int[] values, int[] expected)
        {
            var head = ListBuilder.FromArray(values);

            new S0143().ReorderList(head);

            Assert.Equal(expected, ListBuilder.ToArray(head));
        }

        [Fact]
        public void ReorderList_AllMethodsReturnSameResult()
        {
            var solution = new S0143();
            var first = ListBuilder.FromArray([1, 2, 3, 4, 5, 6]);
            var second = ListBuilder.FromArray([1, 2, 3, 4, 5, 6]);

            solution.ReorderList_FindMiddleReverseMerge(first);
            solution.ReorderList_Stack(second);

            Assert.Equal([1, 6, 2, 5, 3, 4], ListBuilder.ToArray(first));
            Assert.Equal([1, 6, 2, 5, 3, 4], ListBuilder.ToArray(second));
        }
    }
}
