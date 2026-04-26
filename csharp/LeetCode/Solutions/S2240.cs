// 題目：給定總預算 total 與兩種商品單價 cost1、cost2，計算購買筆與鉛筆的所有可行組合數量。
namespace LeetCode.Solutions;
public class S2240
{
    public long WaysToBuyPensPencils(int total, int cost1, int cost2)
    {
        long result = 0;
        int end = total / cost1;
        for (var i = 0; i <= end; i++)
        {
            var remaining = total - (cost1 * i);
            result += remaining / (cost2); // 買 1~n 個 cost2
            result++; // 完全不買 0 個
        }
        return result;
    }
}
