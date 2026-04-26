// 題目：給定密鑰 key 與加密訊息 message，依 key 中第一次出現的字母建立 a-z 對應表，將 message 解碼。
namespace LeetCode.Solutions;
// TODO:
public class S2325
{
    public string DecodeMessage(string key, string message)
    {
        var map = new Dictionary<char, char>();
        var next = 'a';
        foreach (var c in key)
        {
            if (c == ' ' || map.ContainsKey(c)) continue;
            map[c] = next++;
        }
        var result = new char[message.Length];
        for (int i = 0; i < message.Length; i++)
        {
            var c = message[i];
            result[i] = c == ' ' ? ' ' : map[c];
        }
        return new string(result);
    }
}
