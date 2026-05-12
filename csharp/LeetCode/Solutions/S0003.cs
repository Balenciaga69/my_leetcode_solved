// TODO:
// 題目：給定字串 s，找出不含重複字元的最長連續子字串長度。
namespace LeetCode.Solutions;

public class S0003
{
    public int LengthOfLongestSubstring(string s)
    {
        return LengthOfLongestSubstring_MyMethod(s);
    }

    public int LengthOfLongestSubstring_MyMethod(string s)
    {
        // 開左右位置, 如果右邊有重複則直到沒重複為止
        var set = new HashSet<char>();
        var left = 0;
        var result = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (set.Contains(s[right]))
            {
                set.Remove(s[left]);
                left++;
            }

            result = Math.Max(result, right - left + 1);
            set.Add(s[right]);
        }

        return result;
    }
    // 滑動視窗 + Dictionary 記錄每個字元最後出現的位置。
    public int LengthOfLongestSubstring_SlidingWindowLastSeen(string s)
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

    // 另一版：滑動視窗 + HashSet，保留當備用寫法。
    public int LengthOfLongestSubstring_SlidingWindowSet(string s)
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
