namespace Csharp.Done
{
    public class S0014LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strings)
        {
            var longestPrefix = string.Empty;
            var currIndex = 0;
            var continueComparing = true;
            while (continueComparing)
            {
                var theChar = this.GetSameChar(strings, currIndex);
                if (string.IsNullOrEmpty(theChar))
                {
                    continueComparing = false;
                }
                else
                {
                    longestPrefix += theChar;
                    currIndex++;
                }
            }

            return longestPrefix;
        }

        private string GetSameChar(string[] strs, int targetIndex)
        {
            if (targetIndex >= strs[0].Length)
            {
                return string.Empty;
            }

            var targetChar = strs[0][targetIndex];
            for (int i = 1; i < strs.Length; i++)
            {
                if (targetIndex >= strs[i].Length)
                {
                    return string.Empty;
                }

                var currentChar = strs[i][targetIndex];
                if (currentChar != targetChar)
                {
                    return string.Empty;
                }
            }

            return targetChar.ToString();
        }
    }
}