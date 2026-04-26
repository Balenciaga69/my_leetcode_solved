// 題目：根據只包含 'I' 與 'D' 的字串 s，構造一個長度為 s.Length + 1 的排列，使得 I 表示遞增、D 表示遞減。
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
