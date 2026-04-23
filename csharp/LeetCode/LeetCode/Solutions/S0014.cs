namespace LeetCode.Solutions;
public class S0014
{
    public string LongestCommonPrefix(string[] strs)
    {
        var cp = strs[0];
        while (true)
        {
            var isMatch = true;
            for (int i = 1; i < strs.Length; i++)
            {
                if (!strs[i].StartsWith(cp))
                {
                    cp = cp.Remove(cp.Length - 1);
                    isMatch = false; break;
                }
            }
            if (isMatch) return cp;
        }
    }
}
