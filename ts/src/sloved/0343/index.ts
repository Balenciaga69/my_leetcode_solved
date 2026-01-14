/** 
Given an integer n, break it into the sum of k positive integers, where k >= 2, and maximize the product of those integers.

Return the maximum product you can get.
*/
/**
 * FIXME: 這是直接拿的答案
 */
function integerBreak(n: number): number {
  const dp: number[] = new Array(n + 1).fill(0)

  dp[2] = 1

  for (let i = 3; i <= n; i++) {
    for (let j = 1; j < i; j++) {
      const currentProduct = Math.max(j * (i - j), j * dp[i - j])
      dp[i] = Math.max(dp[i], currentProduct)
      console.log(`i: ${i}, j: ${j}, currentProduct: ${currentProduct}, dp[${i}]: ${dp[i]}`)
    }
  }

  return dp[n]
}
integerBreak(10)
