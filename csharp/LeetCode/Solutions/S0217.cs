// 題目：判斷整數陣列 nums 中是否存在至少一個值出現兩次以上；有重複回傳 true，否則回傳 false。
namespace LeetCode.Solutions;
public class S0217
{
    public bool ContainsDuplicate(int[] nums)
    {
        var hs = new HashSet<int>();
        foreach (int x in nums)
        {
           if( hs.Contains(x)) return true;
            hs.Add(x);
        }
        return false;
    }
}
