// TODO:
// 題目：給定每個位置的高度，找出兩條線與 x 軸能形成的最大盛水面積。
namespace LeetCode.Solutions;

public class S0011
{
    private const Method ActiveMethod = Method.TwoPointers;

    private enum Method
    {
        TwoPointers,
        BruteForce
    }

    /*
     * 主方法只負責切換目前採用的解法。
     * 預設使用雙指針，從最寬容器開始往內縮，保留可能提高高度的一側。
     * 時間 O(n)，空間 O(1)，是本題面試偏好的解法。
     */
    public int MaxArea(int[] height)
    {
        return ActiveMethod switch
        {
            Method.TwoPointers => MaxArea_TwoPointers(height),
            Method.BruteForce => MaxArea_BruteForce(height),
            _ => throw new InvalidOperationException("Unknown solution method.")
        };
    }

    /*
     * 左右指針先放在陣列兩端，此時寬度最大。
     * 每次計算面積後，只移動高度較小的一側；因為移動較高側只會讓寬度變小且高度上限不變。
     * 這個貪心縮減可在 O(n) 內掃完所有必要候選。
     */
    public int MaxArea_TwoPointers(int[] height) // __雙指針法
    {
        var left = 0;
        var right = height.Length - 1;
        var maxArea = 0;

        while (left < right)
        {
            var width = right - left;
            var currentHeight = Math.Min(height[left], height[right]);
            maxArea = Math.Max(maxArea, width * currentHeight);

            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }

    /*
     * 枚舉所有左右邊界組合並計算面積。
     * 這是最直觀的基準解，適合用來驗證雙指針結果。
     * 時間 O(n^2)，大輸入會超時，不建議作為正式提交。
     */
    public int MaxArea_BruteForce(int[] height) // __暴力枚舉法
    {
        var maxArea = 0;

        for (var left = 0; left < height.Length; left++)
        {
            for (var right = left + 1; right < height.Length; right++)
            {
                var area = (right - left) * Math.Min(height[left], height[right]);
                maxArea = Math.Max(maxArea, area);
            }
        }

        return maxArea;
    }
}
