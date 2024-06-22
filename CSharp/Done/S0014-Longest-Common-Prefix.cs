namespace Csharp.Done
{
    public class S0014_Longest_Common_Prefix
    {
        public string LongestCommonPrefix(string[] strings)
        {
            var longestPrefix = "";
            var currIndex = 0;
            var continueComparing = true;
            while (continueComparing)
            {
                var theChar = getSameChar(strings, currIndex);
                if (string.IsNullOrEmpty(theChar))
                {
                    continueComparing = false;
                }
                else
                {
                    longestPrefix += theChar;
                    currIndex++;
                }
            };
            return longestPrefix;
        }

        private string getSameChar(string[] strs, int targetIndex)
        {
            if (targetIndex >= strs[0].Length)
            {
                return "";
            }
            var targetChar = strs[0][targetIndex];
            for (int i = 1; i < strs.Length; i++)
            {
                if (targetIndex >= strs[i].Length)
                {
                    return "";
                }
                var currentChar = strs[i][targetIndex];
                if (currentChar != targetChar)
                {
                    return "";
                };
            }
            return targetChar.ToString();
        }
    }
}