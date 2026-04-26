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
