/*
Tags: Array, Dynamic Programming
Date: 2025-10-27
---
給定一個整數陣列 coins，代表不同面額的硬幣，以及一個整數 amount，代表總金額。
請返回能湊成該金額的組合數。
如果無法用任何硬幣組合出該金額，則返回 $0$。
你可以假設每種硬幣都有無限多個。
答案保證能放入一個 $32$ 位元有符號整數。
*/
export function change(amount: number, coins: number[]): number {
  if (amount === 0) return 1
  const dp: number[] = new Array(amount + 1).fill(0)
  for (const coin of coins) {
    for (let i = coin; i <= amount; i++) {
      if (i === coin) dp[i] += 1
      dp[i] += dp[i - coin]
    }
  }
  return dp[amount]
}
