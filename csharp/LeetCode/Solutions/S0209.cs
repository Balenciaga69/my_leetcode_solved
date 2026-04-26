// 題目：給定正整數陣列 nums 與目標值 target，找出總和大於等於 target 的最短連續子陣列長度；若不存在則回傳 0。
namespace LeetCode.Solutions;
// TODO:
public class S0209
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        var l = 0;
        var r = 0;
        var sum = 0;
        var minAryLength = int.MaxValue;
        while (l <= r && r < nums.Length)
        {
            sum += nums[r];
            while (sum >= target)
            {
                minAryLength = Math.Min(r - l + 1, minAryLength);
                sum -= nums[l];
                l++;
            }
            r++;
        }
        return minAryLength == int.MaxValue ? 0 : minAryLength;
    }
}
