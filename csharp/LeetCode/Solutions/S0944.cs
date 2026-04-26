// 題目：給定多個等長字串，計算至少要刪除多少個欄位，才能讓每一欄由上到下都保持非遞減排序。
namespace LeetCode.Solutions;
public class S0944
{
    public int MinDeletionSize(string[] strs)
    {
        var result = 0;
        for (var i = 0; i < strs[0].Length; i++)
        {
            for (var strIdx = 1; strIdx < strs.Length; strIdx++)
            {
                {
                    if (strs[strIdx][i] < strs[strIdx - 1][i])
                    {
                        result++;
                        break;
                    }
                }
            }
        }
        return result;
    }
}
