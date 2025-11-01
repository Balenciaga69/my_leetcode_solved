/*
#1 2025-11-01 [20mins]
---
5. 最长回文子串
給你一個字串 s，請你找出其中 最長的回文子字串（palindromic substring），並回傳它。
回文子字串是指從前往後與從後往前讀都相同的子字串。
---
輸入: s = "babad"
輸出: "bab"
解釋: "aba" 也是一個有效答案。
---
輸入: s = "cbbd"
輸出: "bb"
---
輸入: s = "ac"
輸出: "a"
---
輸入: s = "a"
輸出: "a"
---
1 <= s.length <= 1000
s 只包含英文字母與數字
*/
export function longestPalindrome(s: string): string {
  const n = s.length
  if (n <= 1) return s

  let gl_str = s[0]

  const exec = (left: number, right: number) => {
    while (left >= 0 && right < n && s[left] === s[right]) {
      const currStr = s.substring(left, right + 1)
      const curLen = currStr.length
      if (curLen > gl_str.length) gl_str = currStr
      left--
      right++
    }
  }
  for (let i = 0; i < n; i++) {
    exec(i - 1, i + 1)
    if (i + 1 < n && s[i] === s[i + 1]) {
      if (gl_str.length < 2) gl_str = s.substring(i, i + 2)
      exec(i - 1, i + 2)
    }
  }
  return gl_str
}
