// TODO:
// 題目：給定字串 s，回傳其中所有回文子字串數量。
namespace LeetCode.Solutions;

public class S0647
{
    private const Method ActiveMethod = Method.ExpandAroundCenter;

    private enum Method
    {
        ExpandAroundCenter,
        DynamicProgramming
    }

    /*
     * 主方法只負責切換目前採用的解法。
     * 預設使用中心擴張，分別處理奇數長度與偶數長度回文。
     * 字串長度最多 1000，O(n^2) 可接受且空間 O(1)。
     */
    public int CountSubstrings(string s)
    {
        return ActiveMethod switch
        {
            Method.ExpandAroundCenter => CountSubstrings_ExpandAroundCenter(s),
            Method.DynamicProgramming => CountSubstrings_DynamicProgramming(s),
            _ => throw new InvalidOperationException("Unknown solution method.")
        };
    }

    /*
     * 每個字元可作為奇數回文中心，每兩個字元中間可作為偶數回文中心。
     * 從中心往左右擴張，只要左右字元相同就形成一個新回文子字串。
     * 枚舉所有中心即可計算全部回文子字串。
     */
    public int CountSubstrings_ExpandAroundCenter(string s) // __中心擴張法
    {
        var count = 0;

        for (var center = 0; center < s.Length; center++)
        {
            count += CountFromCenter(s, center, center);
            count += CountFromCenter(s, center, center + 1);
        }

        return count;
    }

    /*
     * isPalindrome[start,end] 表示 s[start..end] 是否為回文。
     * 兩端字元相同，且中間長度小於等於 1 或內部也是回文時成立。
     * 依 end 由小到大填表，確保內部狀態已計算。
     */
    public int CountSubstrings_DynamicProgramming(string s) // __動態規劃法
    {
        var isPalindrome = new bool[s.Length, s.Length];
        var count = 0;

        for (var end = 0; end < s.Length; end++)
        {
            for (var start = 0; start <= end; start++)
            {
                if (s[start] != s[end])
                {
                    continue;
                }

                if (end - start <= 2 || isPalindrome[start + 1, end - 1])
                {
                    isPalindrome[start, end] = true;
                    count++;
                }
            }
        }

        return count;
    }

    private static int CountFromCenter(string s, int left, int right)
    {
        var count = 0;

        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            count++;
            left--;
            right++;
        }

        return count;
    }
}
