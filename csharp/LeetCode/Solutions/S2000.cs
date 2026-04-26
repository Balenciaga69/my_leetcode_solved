// TODO:
// 題目：給定字串 word 與字元 ch，將 word 中從開頭到第一次出現 ch 為止的片段反轉；若找不到 ch 則維持原字串。
namespace LeetCode.Solutions;
public class S2000
{
    public string ReversePrefix(string word, char ch)
    {
        var idx = word.IndexOf(ch);
        if (idx < 0) return word;
        var chars = word.ToCharArray();
        Array.Reverse(chars, 0, idx + 1);
        return new string(chars);
    }
}
