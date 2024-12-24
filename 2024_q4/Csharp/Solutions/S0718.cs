namespace Csharp.Solutions.S0718
{
    public class Solution
    {
        public Solution()
        {
            //var ary1 = new int[] { 1, 2, 3, 2, 1 };
            var ary1 = new int[] { 0, 0, 0, 0, 0 };
            //var ary2 = new int[] { 3, 2, 1, 4, 7 };
            var ary2 = new int[] { 0, 0, 0, 0, 0 };
            this.FindLength(ary1, ary2);
        }

        public int FindLength(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0 || nums2.Length == 0) return 0;
            if (nums1.SequenceEqual(nums2)) return nums1.Length;
            return this.DPMethod(nums1, nums2);
        }

        public int DPMethod(int[] nums1, int[] nums2)
        {
            return 0;
        }

        public int SlidingWindowMethod(int[] nums1, int[] nums2)
        {
            return 0;
        }
    }
}
