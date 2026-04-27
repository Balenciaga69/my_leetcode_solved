// TODO:
// 題目：給定字串 s 與字典 wordDict，判斷 s 是否能被切成一個或多個字典單字。
namespace LeetCode.Solutions;

public class S0139
{
    private const Method ActiveMethod = Method.DynamicProgramming;

    private enum Method
    {
        DynamicProgramming,
        DfsMemo
    }

    /*
     * 主方法只負責切換目前採用的解法。
     * 預設使用一維 DP：canBreak[i] 表示 s[0..i) 是否可被字典切分。
     * 用 HashSet 查字典並限制最大單字長度，避免無效枚舉。
     */
    public bool WordBreak(string s, IList<string> wordDict)
    {
        return ActiveMethod switch
        {
            Method.DynamicProgramming => WordBreak_DynamicProgramming(s, wordDict),
            Method.DfsMemo => WordBreak_DfsMemo(s, wordDict),
            _ => throw new InvalidOperationException("Unknown solution method.")
        };
    }

    /*
     * canBreak[0] 設為 true，代表空字串可被切分。
     * 對每個 end，枚舉最後一個單字長度；若前綴可切且最後單字在字典中，end 即可切分。
     * 時間約 O(n * maxWordLength)，適合本題限制。
     */
    public bool WordBreak_DynamicProgramming(string s, IList<string> wordDict) // __一維DP法
    {
        var words = wordDict.ToHashSet();
        var maxWordLength = wordDict.Max(word => word.Length);
        var canBreak = new bool[s.Length + 1];
        canBreak[0] = true;

        for (var end = 1; end <= s.Length; end++)
        {
            for (var length = 1; length <= maxWordLength && length <= end; length++)
            {
                if (canBreak[end - length] && words.Contains(s.Substring(end - length, length)))
                {
                    canBreak[end] = true;
                    break;
                }
            }
        }

        return canBreak[s.Length];
    }

    /*
     * DFS(start) 表示 s[start..] 是否可被字典切分。
     * 每次嘗試從 start 開始的所有可能單字，成功就往下一段遞迴。
     * memo 記錄失敗或成功的 start，避免重複搜尋同一後綴。
     */
    public bool WordBreak_DfsMemo(string s, IList<string> wordDict) // __DFS記憶化法
    {
        var words = wordDict.ToHashSet();
        var maxWordLength = wordDict.Max(word => word.Length);
        var memo = new Dictionary<int, bool>();

        return CanBreakFrom(0);

        bool CanBreakFrom(int start)
        {
            if (start == s.Length)
            {
                return true;
            }

            if (memo.TryGetValue(start, out var cached))
            {
                return cached;
            }

            for (var length = 1; length <= maxWordLength && start + length <= s.Length; length++)
            {
                if (words.Contains(s.Substring(start, length)) && CanBreakFrom(start + length))
                {
                    memo[start] = true;
                    return true;
                }
            }

            memo[start] = false;
            return false;
        }
    }
}
