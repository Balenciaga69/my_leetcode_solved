// TODO:
// 題目：給定整數陣列 nums，回傳所有總和為 0 且不重複的三元組。
namespace LeetCode.Solutions;

public class S0015
{
    private const Method ActiveMethod = Method.SortTwoPointers;

    private enum Method
    {
        SortTwoPointers,
        HashSetPerFixed
    }

    /*
     * 主方法只負責切換目前採用的解法。
     * 預設使用排序後固定第一個數，再用雙指針找剩餘兩數。
     * 透過跳過相同值避免重複三元組，時間 O(n^2)。
     */
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        return ActiveMethod switch
        {
            Method.SortTwoPointers => ThreeSum_SortTwoPointers(nums),
            Method.HashSetPerFixed => ThreeSum_HashSetPerFixed(nums),
            _ => throw new InvalidOperationException("Unknown solution method.")
        };
    }

    /*
     * 先排序，固定 i 後把問題降成 Two Sum。
     * left/right 根據總和往內移動；找到答案後跳過重複 left/right 值。
     * 排序讓去重與指針移動都很自然，是面試最常見寫法。
     */
    public IList<IList<int>> ThreeSum_SortTwoPointers(int[] nums) // __排序雙指針法
    {
        Array.Sort(nums);
        var result = new List<IList<int>>();

        for (var i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            if (nums[i] > 0)
            {
                break;
            }

            var left = i + 1;
            var right = nums.Length - 1;

            while (left < right)
            {
                var sum = nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    result.Add([nums[i], nums[left], nums[right]]);
                    left++;
                    right--;

                    while (left < right && nums[left] == nums[left - 1])
                    {
                        left++;
                    }

                    while (left < right && nums[right] == nums[right + 1])
                    {
                        right--;
                    }
                }
                else if (sum < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return result;
    }

    /*
     * 固定第一個數，後續用 HashSet 尋找 complement。
     * 因為陣列已排序，固定點與找到答案後都能跳過重複值。
     * 時間 O(n^2)，但去重細節比雙指針更容易寫錯。
     */
    public IList<IList<int>> ThreeSum_HashSetPerFixed(int[] nums) // __固定一點HashSet法
    {
        Array.Sort(nums);
        var result = new List<IList<int>>();

        for (var i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            var seen = new HashSet<int>();

            for (var j = i + 1; j < nums.Length; j++)
            {
                var complement = -nums[i] - nums[j];

                if (seen.Contains(complement))
                {
                    result.Add([nums[i], complement, nums[j]]);

                    while (j + 1 < nums.Length && nums[j] == nums[j + 1])
                    {
                        j++;
                    }
                }

                seen.Add(nums[j]);
            }
        }

        return result;
    }
}
