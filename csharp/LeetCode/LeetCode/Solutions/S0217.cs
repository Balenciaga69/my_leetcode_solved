namespace LeetCode.Solutions;
public class S0217
{
    public bool ContainsDuplicate(int[] nums)
    {
        var hs = new HashSet<int>();
        foreach (int x in nums)
        {
           if( hs.Contains(x)) return true;
            hs.Add(x);
        }
        return false;
    }
}
