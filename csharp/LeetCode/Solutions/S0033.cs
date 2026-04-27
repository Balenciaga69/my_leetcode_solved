// TODO:
// 題目：給定不重複且可能旋轉的遞增排序陣列 nums，以 O(log n) 搜尋 target 的索引。
namespace LeetCode.Solutions;

public class S0033
{
    private const Method ActiveMethod = Method.OnePassBinarySearch;

    private enum Method
    {
        OnePassBinarySearch,
        FindPivotThenBinarySearch
    }

    /*
     * 主方法只負責切換目前採用的解法。
     * 預設使用一次二分搜尋，每輪判斷左半或右半哪一段仍保持排序。
     * 根據 target 是否落在排序區間內縮小搜尋範圍，時間 O(log n)。
     */
    public int Search(int[] nums, int target)
    {
        return ActiveMethod switch
        {
            Method.OnePassBinarySearch => Search_OnePassBinarySearch(nums, target),
            Method.FindPivotThenBinarySearch => Search_FindPivotThenBinarySearch(nums, target),
            _ => throw new InvalidOperationException("Unknown solution method.")
        };
    }

    /*
     * 每次取 mid 後，先判斷 nums[left..mid] 是否有序。
     * 若 target 落在有序半邊，就丟棄另一半；否則搜尋另一半。
     * 不需要先找 pivot，是本題最精簡的 O(log n) 寫法。
     */
    public int Search_OnePassBinarySearch(int[] nums, int target) // __一次二分法
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }

            if (nums[left] <= nums[mid])
            {
                if (nums[left] <= target && target < nums[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            else
            {
                if (nums[mid] < target && target <= nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }

        return -1;
    }

    /*
     * 先用二分找出旋轉後最小值的位置，也就是 pivot。
     * 再根據 target 範圍決定要在 pivot 右側或左側做一般二分搜尋。
     * 流程較長，但概念分離清楚。
     */
    public int Search_FindPivotThenBinarySearch(int[] nums, int target) // __先找Pivot再二分法
    {
        var pivot = FindPivot(nums);
        var left = 0;
        var right = nums.Length - 1;

        if (target >= nums[pivot] && target <= nums[right])
        {
            left = pivot;
        }
        else
        {
            right = pivot - 1;
        }

        while (left <= right)
        {
            var mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }

            if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }

    private static int FindPivot(int[] nums)
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

        return left;
    }
}
