// TODO:
// 題目：給定整數陣列 nums 與整數 k，回傳滿足 i < j 且 |nums[i] - nums[j]| == k 的索引對數量。
namespace LeetCode.Solutions;
public class S2006
{
    public int CountKDifference(int[] nums, int k)
    {
        var count = 0;
        var freq = new int[101];
        foreach (var n in nums)
        {
            if (n - k >= 1) count += freq[n - k];
            if (n + k <= 100) count += freq[n + k];
            freq[n]++;
        }
        return count;
    }
}
