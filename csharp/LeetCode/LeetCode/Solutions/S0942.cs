namespace LeetCode.Solutions;

public class S0942
{
    public int[] DiStringMatch(string s)
    {
        var low = 0;
        var high = s.Length;
        var ls = new List<int>();
        foreach (var c in s)
        {
            if (c == 'D')
            {
                ls.Add(high);
                high--;
            }
            else
            {
                ls.Add(low);
                low++;
            }
        }
        ls.Add(low);
        return ls.ToArray();
    }
}
