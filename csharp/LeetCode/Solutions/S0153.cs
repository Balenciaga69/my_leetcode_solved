// TODO:
// 題目：給定不重複且已旋轉的遞增排序陣列 nums，以 O(log n) 回傳最小值。
namespace LeetCode.Solutions;

public class S0153
{
    private const Method ActiveMethod = Method.BinarySearchRightCompare;

    private enum Method
    {
        BinarySearchRightCompare,
        BinarySearchFindPivot
    }

    /*
     * 主方法只負責切換目前採用的解法。
     * 預設用二分比較 nums[mid] 與 nums[right]，判斷最小值位於哪一側。
     * 陣列元素不重複，所以每次都能明確縮小範圍，時間 O(log n)。
     */
    public int FindMin(int[] nums)
    {
        return ActiveMethod switch
        {
            Method.BinarySearchRightCompare => FindMin_BinarySearchRightCompare(nums),
            Method.BinarySearchFindPivot => FindMin_BinarySearchFindPivot(nums),
            _ => throw new InvalidOperationException("Unknown solution method.")
        };
    }

    /*
     * 若 nums[mid] > nums[right]，代表 mid 位於左側較大區間，最小值在右半。
     * 否則 mid 可能就是最小值，或最小值在左半，因此保留 mid。
     * left == right 時即為旋轉後最小值位置。
     */
    public int FindMin_BinarySearchRightCompare(int[] nums) // __二分右界比較法
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            var mid = left + (right - left) / 2;

            if (nums[mid] > nums[right])
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        return nums[left];
    }

    /*
     * 先處理未旋轉情況，否則用二分尋找第一個比前一個元素小的位置。
     * nums[mid] 若仍大於等於 nums[0]，表示 pivot 在右側；否則在左側。
     * 概念接近直接找旋轉斷點。
     */
    public int FindMin_BinarySearchFindPivot(int[] nums) // __二分Pivot法
    {
        if (nums[0] <= nums[^1])
        {
            return nums[0];
        }

        var left = 0;
        var right = nums.Length - 1;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;

            if (mid > 0 && nums[mid] < nums[mid - 1])
            {
                return nums[mid];
            }

            if (nums[mid] >= nums[0])
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return nums[0];
    }
}
