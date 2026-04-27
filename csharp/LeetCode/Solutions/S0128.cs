// TODO:
// 題目：給定未排序整數陣列 nums，回傳最長連續元素序列的長度；要求 O(n) 時間。
namespace LeetCode.Solutions;

public class S0128
{
    private const Method ActiveMethod = Method.HashSetStartScan;

    private enum Method
    {
        HashSetStartScan,
        HashSetRemoveExpand
    }

    /*
     * 主方法只負責切換目前採用的解法。
     * 預設使用 HashSet 找每段連續序列的起點，只從沒有前驅 num - 1 的數開始延伸。
     * 每個數最多被查找常數次，平均時間 O(n)。
     */
    public int LongestConsecutive(int[] nums)
    {
        return ActiveMethod switch
        {
            Method.HashSetStartScan => LongestConsecutive_HashSetStartScan(nums),
            Method.HashSetRemoveExpand => LongestConsecutive_HashSetRemoveExpand(nums),
            _ => throw new InvalidOperationException("Unknown solution method.")
        };
    }

    /*
     * 先把所有數放入 HashSet 支援 O(1) 查找。
     * 只有當 num - 1 不存在時，num 才是某段連續序列的起點。
     * 從起點一路查 num + 1、num + 2...，避免從每個元素重複掃描。
     */
    public int LongestConsecutive_HashSetStartScan(int[] nums) // __HashSet起點掃描法
    {
        var set = new HashSet<int>(nums);
        var maxLength = 0;

        foreach (var num in set)
        {
            if (set.Contains(num - 1))
            {
                continue;
            }

            var current = num;
            var length = 1;

            while (set.Contains(current + 1))
            {
                current++;
                length++;
            }

            maxLength = Math.Max(maxLength, length);
        }

        return maxLength;
    }

    /*
     * 每次遇到尚未處理的數，就把它從 HashSet 移除並向左右擴張。
     * 擴張過程中也移除已納入序列的數，確保每個元素只處理一次。
     * 平均時間 O(n)，但寫法比起點掃描更偏技巧型。
     */
    public int LongestConsecutive_HashSetRemoveExpand(int[] nums) // __HashSet移除擴張法
    {
        var set = new HashSet<int>(nums);
        var maxLength = 0;

        foreach (var num in nums)
        {
            if (!set.Remove(num))
            {
                continue;
            }

            var left = num - 1;
            var right = num + 1;

            while (set.Remove(left))
            {
                left--;
            }

            while (set.Remove(right))
            {
                right++;
            }

            maxLength = Math.Max(maxLength, right - left - 1);
        }

        return maxLength;
    }
}
