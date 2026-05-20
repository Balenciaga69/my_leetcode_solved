// TODO:
// 題目：給定硬幣面額陣列 coins 與金額 amount，回傳湊出該金額所需的最少硬幣數；若無法湊出則回傳 -1。
namespace LeetCode.Solutions;

public class S0322
{
    /*
     * 這題是完全背包的最少步數版本。
     * dp[value] 表示湊出金額 value 所需的最少硬幣數，逐步由小金額推到大金額。
     * 若 dp[amount] 仍是初始無限大，代表無法組成答案。
     */
    public int CoinChange(int[] coins, int amount)
    {
        return CoinChange_DynamicProgrammingBottomUp(coins, amount);
    }

    /*
     * 對每個金額 value，枚舉最後一枚使用的硬幣 coin。
     * 如果 value - coin 可達，就能由 dp[value - coin] + 1 更新 dp[value]。
     * 時間 O(amount * coins.Length)，空間 O(amount)。
     */
    public int CoinChange_DynamicProgrammingBottomUp(int[] coins, int amount) // __一維DP自底向上法
    {
        var dp = new int[amount + 1];
        Array.Fill(dp, amount + 1);
        dp[0] = 0;

        for (var value = 1; value <= amount; value++)
        {
            foreach (var coin in coins)
            {
                if (coin <= value)
                {
                    dp[value] = Math.Min(dp[value], dp[value - coin] + 1);
                }
            }
        }

        return dp[amount] > amount ? -1 : dp[amount];
    }

    /*
     * 改成先枚舉硬幣、再往右更新金額，也是一維完全背包寫法。
     * 每種硬幣都可以被重複使用，因此 value 從 coin 往 amount 遞增即可。
     */
    public int CoinChange_DynamicProgrammingCompleteKnapsack(int[] coins, int amount) // __完全背包DP法
    {
        var dp = new int[amount + 1];
        Array.Fill(dp, amount + 1);
        dp[0] = 0;

        foreach (var coin in coins)
        {
            for (var value = coin; value <= amount; value++)
            {
                dp[value] = Math.Min(dp[value], dp[value - coin] + 1);
            }
        }

        return dp[amount] > amount ? -1 : dp[amount];
    }

    /*
     * 以 BFS 把每個金額視為節點，從 0 出發每次加上一枚硬幣。
     * 因為 BFS 依層擴展，第一次到達 amount 時的步數就是最少硬幣數。
     * 實作直觀，但通常常數較大。
     */
    public int CoinChange_BreadthFirstSearch(int[] coins, int amount) // __BFS層級搜尋法
    {
        if (amount == 0)
        {
            return 0;
        }

        var visited = new bool[amount + 1];
        var queue = new Queue<int>();
        queue.Enqueue(0);
        visited[0] = true;
        var steps = 0;

        while (queue.Count > 0)
        {
            steps++;
            var levelCount = queue.Count;

            for (var i = 0; i < levelCount; i++)
            {
                var current = queue.Dequeue();

                foreach (var coin in coins)
                {
                    var next = current + coin;

                    if (next == amount)
                    {
                        return steps;
                    }

                    if (next < amount && !visited[next])
                    {
                        visited[next] = true;
                        queue.Enqueue(next);
                    }
                }
            }
        }

        return -1;
    }
}
