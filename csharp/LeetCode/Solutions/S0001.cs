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
