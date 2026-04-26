// TODO:
// 題目：給定整數陣列 nums，找出最左邊的 middle index，使其左側總和等於右側總和；若不存在則回傳 -1。
namespace LeetCode.Solutions;
public class S1991
{
    public int FindMiddleIndex(int[] nums)
    {
        var total = 0;
        foreach (var n in nums) total += n;
        var left = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (left == total - left - nums[i]) return i;
            left += nums[i];
        }
        return -1;
    }
}
