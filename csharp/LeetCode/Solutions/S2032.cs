// TODO:
// 題目：給定三個整數陣列 nums1、nums2、nums3，回傳所有至少出現在其中兩個陣列中的不同整數，順序不限。
namespace LeetCode.Solutions;
public class S2032
{
    public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
    {
        var counts = new Dictionary<int, int>();
        foreach (var set in new[]
        {
            new HashSet<int>(nums1),
            new HashSet<int>(nums2),
            new HashSet<int>(nums3),
        })
        {
            foreach (var n in set)
            {
                counts[n] = counts.GetValueOrDefault(n) + 1;
            }
        }

        var result = new List<int>();
        foreach (var kv in counts)
        {
            if (kv.Value >= 2) result.Add(kv.Key);
        }
        return result;
    }
}
