// TODO:
// 題目：給定學生分數陣列 nums 與整數 k，從任意 k 個學生中選出分數，使最高分與最低分的差值最小，回傳該最小差值。
namespace LeetCode.Solutions;
public class S1984
{
    public int MinimumDifference(int[] nums, int k)
    {
        Array.Sort(nums);
        var answer = int.MaxValue;
        // 已經排序過 所有 k - i 的落差必定是最大比最小
        for (var i = 0; i + k - 1 < nums.Length; i++)
        {
            answer = Math.Min(answer, nums[i + k - 1] - nums[i]);
        }
        return answer;
    }
}
