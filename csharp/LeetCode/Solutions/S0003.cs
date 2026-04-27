// TODO:
// 題目：給定字串 s，找出不含重複字元的最長連續子字串長度。
namespace LeetCode.Solutions;

public class S0003
{
    private const Method ActiveMethod = Method.SlidingWindowLastSeen;

    private enum Method
    {
        SlidingWindowLastSeen,
        SlidingWindowSet
    }

    /*
     * 主方法只負責切換目前採用的解法。
     * 預設使用 LastSeen 滑動視窗：遇到重複字元時，直接把左界跳到上次出現位置後一格。
     * 這比逐格移除更適合面試說明，時間 O(n)，空間 O(min(n, 字元集大小))。
     */
    public int LengthOfLongestSubstring(string s)
    {
        return ActiveMethod switch
        {
            Method.SlidingWindowLastSeen => LengthOfLongestSubstring_SlidingWindowLastSeen(s),
            Method.SlidingWindowSet => LengthOfLongestSubstring_SlidingWindowSet(s),
            _ => throw new InvalidOperationException("Unknown solution method.")
        };
    }

    /*
     * 用 Dictionary 記錄每個字元最近一次出現的索引。
     * 右指針逐字掃描；若目前字元曾在視窗內出現，左指針直接跳過舊位置。
     * 每個字元只被右指針處理一次，所以時間 O(n)。
     */
    public int LengthOfLongestSubstring_SlidingWindowLastSeen(string s) // __滑動視窗LastSeen法
    {
        var lastSeen = new Dictionary<char, int>();
        var left = 0;
        var maxLength = 0;

        for (var right = 0; right < s.Length; right++)
        {
            var c = s[right];

            if (lastSeen.TryGetValue(c, out var previousIndex) && previousIndex >= left)
            {
                left = previousIndex + 1;
            }

            lastSeen[c] = right;
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }

    /*
     * 用 HashSet 維護目前視窗內的字元。
     * 當右指針遇到重複字元時，左指針逐步移動並移除字元，直到重複消失。
     * 寫法直觀，時間仍是 O(n)，因為每個字元最多進出視窗一次。
     */
    public int LengthOfLongestSubstring_SlidingWindowSet(string s) // __滑動視窗HashSet法
    {
        var window = new HashSet<char>();
        var left = 0;
        var maxLength = 0;

        for (var right = 0; right < s.Length; right++)
        {
            while (window.Contains(s[right]))
            {
                window.Remove(s[left]);
                left++;
            }

            window.Add(s[right]);
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
