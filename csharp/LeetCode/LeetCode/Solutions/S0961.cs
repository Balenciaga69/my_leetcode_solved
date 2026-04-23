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
