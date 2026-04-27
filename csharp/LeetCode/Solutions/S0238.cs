// TODO:
// 題目：給定整數陣列 nums，回傳每個位置以外所有元素的乘積；不可使用除法。
namespace LeetCode.Solutions;

public class S0238
{
    private const Method ActiveMethod = Method.OutputPrefixSuffix;

    private enum Method
    {
        OutputPrefixSuffix,
        PrefixSuffixArrays
    }

    /*
     * 主方法只負責切換目前採用的解法。
     * 預設把輸出陣列先填成左側乘積，再由右往左乘上右側乘積。
     * 不使用除法，且除了輸出陣列外只用 O(1) 額外空間。
     */
    public int[] ProductExceptSelf(int[] nums)
    {
        return ActiveMethod switch
        {
            Method.OutputPrefixSuffix => ProductExceptSelf_OutputPrefixSuffix(nums),
            Method.PrefixSuffixArrays => ProductExceptSelf_PrefixSuffixArrays(nums),
            _ => throw new InvalidOperationException("Unknown solution method.")
        };
    }

    /*
     * 第一趟從左到右，answer[i] 先存 nums[i] 左側所有數的乘積。
     * 第二趟從右到左，用 suffix 保存右側乘積並乘回 answer[i]。
     * 這樣每個位置就得到左側乘積 * 右側乘積。
     */
    public int[] ProductExceptSelf_OutputPrefixSuffix(int[] nums) // __輸出陣列前後綴法
    {
        var answer = new int[nums.Length];
        var prefix = 1;

        for (var i = 0; i < nums.Length; i++)
        {
            answer[i] = prefix;
            prefix *= nums[i];
        }

        var suffix = 1;

        for (var i = nums.Length - 1; i >= 0; i--)
        {
            answer[i] *= suffix;
            suffix *= nums[i];
        }

        return answer;
    }

    /*
     * left[i] 保存 i 左側所有數乘積，right[i] 保存 i 右側所有數乘積。
     * 最後 answer[i] = left[i] * right[i]。
     * 概念最直觀，但需要 O(n) 額外空間。
     */
    public int[] ProductExceptSelf_PrefixSuffixArrays(int[] nums) // __左右乘積陣列法
    {
        var left = new int[nums.Length];
        var right = new int[nums.Length];
        var answer = new int[nums.Length];

        left[0] = 1;
        right[^1] = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            left[i] = left[i - 1] * nums[i - 1];
        }

        for (var i = nums.Length - 2; i >= 0; i--)
        {
            right[i] = right[i + 1] * nums[i + 1];
        }

        for (var i = 0; i < nums.Length; i++)
        {
            answer[i] = left[i] * right[i];
        }

        return answer;
    }
}
