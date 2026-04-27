// TODO:
// 題目：給定兩個字串 text1、text2，回傳它們最長共同子序列的長度。
namespace LeetCode.Solutions;

public class S1143
{
    private const Method ActiveMethod = Method.DynamicProgramming1D;

    private enum Method
    {
        DynamicProgramming1D,
        DynamicProgramming2D
    }

    /*
     * 主方法只負責切換目前採用的解法。
     * 預設使用一維 DP 滾動陣列，從字串尾端往前計算。
     * 狀態代表 text1[i..] 與 text2[j..] 的 LCS 長度。
     */
    public int LongestCommonSubsequence(string text1, string text2)
    {
        return ActiveMethod switch
        {
            Method.DynamicProgramming1D => LongestCommonSubsequence_DynamicProgramming1D(text1, text2),
            Method.DynamicProgramming2D => LongestCommonSubsequence_DynamicProgramming2D(text1, text2),
            _ => throw new InvalidOperationException("Unknown solution method.")
        };
    }

    /*
     * previousRow 表示 i + 1 那一列的 DP 結果，currentRow 表示目前 i。
     * 若兩字元相同，答案是 1 + previousRow[j + 1]；不同則取跳過任一字元的較大值。
     * 只保留兩列資訊，空間 O(text2.Length)。
     */
    public int LongestCommonSubsequence_DynamicProgramming1D(string text1, string text2) // __一維DP法
    {
        var previousRow = new int[text2.Length + 1];

        for (var i = text1.Length - 1; i >= 0; i--)
        {
            var currentRow = new int[text2.Length + 1];

            for (var j = text2.Length - 1; j >= 0; j--)
            {
                if (text1[i] == text2[j])
                {
                    currentRow[j] = 1 + previousRow[j + 1];
                }
                else
                {
                    currentRow[j] = Math.Max(previousRow[j], currentRow[j + 1]);
                }
            }

            previousRow = currentRow;
        }

        return previousRow[0];
    }

    /*
     * dp[i,j] 表示 text1[i..] 與 text2[j..] 的 LCS 長度。
     * 從右下往左上填表，因為狀態會依賴右方、下方與右下方。
     * 寫法最符合遞推定義，空間 O(mn)。
     */
    public int LongestCommonSubsequence_DynamicProgramming2D(string text1, string text2) // __二維DP法
    {
        var dp = new int[text1.Length + 1, text2.Length + 1];

        for (var i = text1.Length - 1; i >= 0; i--)
        {
            for (var j = text2.Length - 1; j >= 0; j--)
            {
                if (text1[i] == text2[j])
                {
                    dp[i, j] = 1 + dp[i + 1, j + 1];
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i + 1, j], dp[i, j + 1]);
                }
            }
        }

        return dp[0, 0];
    }
}
