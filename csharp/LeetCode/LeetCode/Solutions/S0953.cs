using System.Collections;

namespace LeetCode.Solutions;

public class S0953
{
    public bool IsAlienSorted(string[] words, string order)
    {
        Hashtable table = new Hashtable();
        table.Add(' ', -1);
        for (int i = 0; i <= order.Length - 1; i++)
        {
            table[order[i]] = i;
        }

        for (int i = 1; i < words.Length; i++)
        {
            var curr = words[i];
            var prev = words[i - 1];
            if (curr.Length < prev.Length) curr = curr.PadRight(prev.Length);
            if (curr.Length > prev.Length) prev = prev.PadRight(curr.Length);
            for (var j = 0; j < curr.Length; j++)
            {
                var currVal = Convert.ToInt32(table[curr[j]]);
                var prevVal = Convert.ToInt32(table[prev[j]]);
                if (currVal > prevVal) break;
                if (currVal < prevVal) return false;
            }
        }
        return true;
    }
}
