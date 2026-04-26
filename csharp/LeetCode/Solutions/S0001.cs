// 題目：給定整數陣列 nums 與整數 target，找出兩個不同元素，使其和等於 target，回傳這兩個元素的索引。
namespace LeetCode.Solutions;
public class S0001
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>(); // val, idx
        for (int i = 0; i < nums.Length; i++)
        {
            var n = nums[i];
            var isMatch = dict.TryGetValue(target - n, out var idx);
            if (isMatch) return new int[] { idx, i };
            else dict[n] = i;
        }
        return Array.Empty<int>();
    }
}
