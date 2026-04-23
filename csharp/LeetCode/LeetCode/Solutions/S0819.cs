using System.Text;

namespace LeetCode.Solutions;

public class S0819
{
    public string MostCommonWord(string paragraph, string[] banned)
    {
        var sb = new StringBuilder();

        foreach (char c in paragraph)
        {
            if (char.IsLetter(c))
                sb.Append(char.ToLower(c));
            else
                sb.Append(' ');
        }

        var words = sb.ToString()
                      .Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var bannedSet = new HashSet<string>(banned);
        var dict = new Dictionary<string, int>();

        string maxWord = "";
        int maxTimes = 0;

        foreach (var word in words)
        {
            if (bannedSet.Contains(word)) continue;

            dict[word] = dict.ContainsKey(word) ? dict[word] + 1 : 1;

            if (dict[word] > maxTimes)
            {
                maxTimes = dict[word];
                maxWord = word;
            }
        }

        return maxWord;
    }
}