namespace LeetCode.Solutions;
// TODO:
public class S0209
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        var left = 0;
        var sum = 0;
        var answer = int.MaxValue;
        for (int right = 0; right < nums.Length; right++)
        {
            sum += nums[right];
            while (sum >= target)
            {
                answer = Math.Min(answer, right - left + 1);
                sum -= nums[left++];
            }
        }
        return answer == int.MaxValue ? 0 : answer;
    }
}
