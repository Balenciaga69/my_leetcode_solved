// TODO:
// 題目：給定整數陣列 nums，計算索引 a < b < c < d 且 nums[a] + nums[b] + nums[c] == nums[d] 的特殊四元組數量。
namespace LeetCode.Solutions;
public class S1995
{
    public int CountQuadruplets(int[] nums)
    {
        var count = 0;
        for (var a = 0; a < nums.Length - 3; a++)
        for (var b = a + 1; b < nums.Length - 2; b++)
        for (var c = b + 1; c < nums.Length - 1; c++)
        for (var d = c + 1; d < nums.Length; d++)
        {
            if (nums[a] + nums[b] + nums[c] == nums[d]) count++;
        }
        return count;
    }
}
