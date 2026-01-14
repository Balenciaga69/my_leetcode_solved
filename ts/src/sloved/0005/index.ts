// Given a string s, return the longest palindromic substring in s.

export function longestPalindrome(s: string): string {
  return dynamicProgramming(s)
}

// 方法一: 中心擴展法
/**
 * Date: 2026-01-13
 */
export function expandFromCenter(s: string): string {
  function findPalindrome(s: string, left: number, right: number): string {
    while (left >= 0 && right < s.length && s[left] === s[right]) {
      left--
      right++
    }
    return s.slice(left + 1, right)
  }
  let finalStr = ''
  for (let i = 0; i < s.length; i++) {
    let curStr = ''
    if (i !== s.length - 1 && s[i] === s[i + 1]) {
      curStr = findPalindrome(s, i, i + 1)
      const isLonger = curStr.length > finalStr.length
      if (isLonger) finalStr = curStr
    }
    curStr = findPalindrome(s, i, i)
    const isLonger = curStr.length > finalStr.length
    if (isLonger) finalStr = curStr
  }
  return finalStr
}

// 方法二: 動態規劃
/**
 * Date: 2026-01-13
 */
export function dynamicProgramming(s: string): string {
  const n = s.length
  if (n < 2) return s
  const dp: boolean[][] = []
  for (let i = 0; i < n; i++) {
    dp[i] = new Array(n).fill(false)
    dp[i][i] = true
  }
  let start = 0
  let maxLength = 1
  for (let j = 1; j < n; j++) {
    for (let i = 0; i < j; i++) {
      if (s[i] === s[j]) {
        // 奇數 或 偶數開端
        if (j - i === 1 || j - i === 2) {
          dp[i][j] = true
        } else {
          dp[i][j] = dp[i + 1][j - 1] // 等於更靠內層的狀態
        }
        if (dp[i][j] && j - i + 1 > maxLength) {
          start = i
          maxLength = j - i + 1
        }
      }
    }
  }
  return s.slice(start, start + maxLength)
}
