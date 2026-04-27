// 題目：給定正整數陣列 nums 與目標值 target，找出總和大於等於 target 的最短連續子陣列長度；若不存在則回傳 0。
namespace LeetCode.Solutions;
// TODO:
public class S0209
{
    /*
     * 因為 nums 都是正整數，視窗總和會隨右界增加、左界移動而單調變化。
     * 右界逐步擴張直到 sum >= target，再盡量收縮左界更新最短長度。
     * 每個元素最多被加入與移出一次，時間 O(n)，空間 O(1)。
     */
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
