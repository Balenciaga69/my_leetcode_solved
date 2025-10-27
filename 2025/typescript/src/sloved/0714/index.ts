/** 
給你一個整數陣列 `coins`，代表不同面額的硬幣，以及一個整數 `amount`，代表目標金額。
請回傳「湊出該金額所需最少硬幣數量」。
如果無法湊出該金額，回傳 -1。
你可以假設每種硬幣數量無限。
---
範例 1：
輸入: coins = [1, 2, 5], amount = 11
輸出: 3
解釋: 11 = 5 + 5 + 1
---
範例 2：
輸入: coins = [2], amount = 3
輸出: -1
---
範例 3：
輸入: coins = [1], amount = 0
輸出: 0
---
限制條件：
1 <= coins.length <= 12
1 <= coins[i] <= 2^31 - 1
0 <= amount <= 10^4
*/
export function coinChange(coins: number[], amount: number): number {
  if (amount === 0) return 0

  const dp: number[] = new Array(amount + 1).fill(Number.MAX_VALUE)
  dp[0] = 0

  for (let i = 1; i <= amount; i++) {
    for (const coin of coins) {
      if (i >= coin) { //  7元 不能用 10元硬幣換
        dp[i] = Math.min(dp[i], dp[i - coin] + 1)
      }
    }
  }
  return dp[amount] === Number.MAX_VALUE ? -1 : dp[amount]
}

// [2,5],8
// 1 : x
// 2 : 1
// 3 : x
// 4 : d[2]+1
// 5 : 1
// 6 : dp[1]+1 or dp[4]+1
// 7 : dp[5]+1 or dp[2]+1
// 8 : dp[3]+1 or 
