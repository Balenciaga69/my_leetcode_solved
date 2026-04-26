// 題目：給定字串陣列 strs，找出所有字串共同擁有的最長前綴；若不存在共同前綴，回傳空字串。
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
