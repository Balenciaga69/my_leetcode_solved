// 題目：給定長度為 2N 的陣列 nums，其中有一個元素重複 N 次，找出該重複元素。
namespace LeetCode.Solutions;
public class S0961
{
    public int RepeatedNTimes(int[] nums)
    {
        var hs = new HashSet<int>();
        foreach (var x in nums)
        {
            if (hs.Contains(x)) return x;
            hs.Add(x);
        }
        return -1;
    }
}
