using LeetCode.Solutions;
namespace LeetCode.Test
{
    public class S0088Tests
    {
        [Fact]
        public void Merge_CombinesSortedArrays()
        {
            int[] nums1 = [1, 2, 3, 0, 0, 0];
            new S0088().Merge(nums1, 3, [2, 5, 6], 3);
            Assert.Equal([1, 2, 2, 3, 5, 6], nums1);
        }
        [Fact]
        public void Merge_LeavesSingleElementArrayUnchanged_WhenSecondArrayIsEmpty()
        {
            int[] nums1 = [1];
            new S0088().Merge(nums1, 1, [], 0);
            Assert.Equal([1], nums1);
        }
        [Fact]
        public void Merge_CopiesSecondArray_WhenFirstArrayHasNoElements()
        {
            int[] nums1 = [0];
            new S0088().Merge(nums1, 0, [1], 1);
            Assert.Equal([1], nums1);
        }
    }
}
