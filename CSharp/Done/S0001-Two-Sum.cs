namespace Csharp.Done
{
    using System.Collections;

    public class S0001TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var hTable = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                var nowNum = nums[i];
                var goodNum = target - nowNum;
                if (hTable.ContainsKey(goodNum))
                {
                    var rowValue = (int?)hTable[goodNum] ?? -1;
                    return new int[] { rowValue, i };
                }
                else if (hTable.ContainsKey(nowNum) == false)
                {
                    hTable.Add(nowNum, i);
                }
            }

            return new int[] { -1, -1 };
        }
    }
}
