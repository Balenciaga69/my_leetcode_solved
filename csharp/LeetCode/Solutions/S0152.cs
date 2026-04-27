// TODO:
// 題目：給定整數陣列 nums，找出乘積最大的連續子陣列並回傳該乘積。
namespace LeetCode.Solutions;

public class S0152
{
    private const Method ActiveMethod = Method.TrackMaxMinProduct;

    private enum Method
    {
        TrackMaxMinProduct,
        PrefixSuffix
    }

    /*
     * 主方法只負責切換目前採用的解法。
     * 預設同時追蹤以目前位置結尾的最大與最小乘積。
     * 負數會讓最大/最小互換，因此必須同時保存兩者。
     */
    public int MaxProduct(int[] nums)
    {
        return ActiveMethod switch
        {
            Method.TrackMaxMinProduct => MaxProduct_TrackMaxMinProduct(nums),
            Method.PrefixSuffix => MaxProduct_PrefixSuffix(nums),
            _ => throw new InvalidOperationException("Unknown solution method.")
        };
    }

    /*
     * currentMax/currentMin 分別表示以目前位置結尾的最大與最小乘積。
     * 遇到負數先交換兩者，再乘上目前值更新。
     * 每一步用 currentMax 更新全域答案，時間 O(n)，空間 O(1)。
     */
    public int MaxProduct_TrackMaxMinProduct(int[] nums) // __最大最小乘積DP法
    {
        var currentMax = nums[0];
        var currentMin = nums[0];
        var answer = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            var num = nums[i];

            if (num < 0)
            {
                (currentMax, currentMin) = (currentMin, currentMax);
            }

            currentMax = Math.Max(num, currentMax * num);
            currentMin = Math.Min(num, currentMin * num);
            answer = Math.Max(answer, currentMax);
        }

        return answer;
    }

    /*
     * 從左到右與從右到左同時累乘，遇到 0 就重置乘積。
     * 負數個數為奇數時，最大乘積可能來自捨棄最左或最右一段。
     * 前後綴掃描能涵蓋這兩種情況。
     */
    public int MaxProduct_PrefixSuffix(int[] nums) // __前後綴乘積法
    {
        var prefix = 1;
        var suffix = 1;
        var answer = int.MinValue;

        for (var i = 0; i < nums.Length; i++)
        {
            if (prefix == 0)
            {
                prefix = 1;
            }

            if (suffix == 0)
            {
                suffix = 1;
            }

            prefix *= nums[i];
            suffix *= nums[nums.Length - 1 - i];
            answer = Math.Max(answer, Math.Max(prefix, suffix));
        }

        return answer;
    }
}
