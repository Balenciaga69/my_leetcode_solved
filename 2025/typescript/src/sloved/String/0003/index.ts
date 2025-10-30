/*
Tags: Hash Table, String, Sliding Window
Date: 2025-10-25
TimeSpent: 37 mins
---
3. 无重复字符的最长子串
Given a string s, find the length of the longest substring without duplicate characters.
給定一個字串 s，求最長的長度 子字串，沒有重複字元。
Constraints:
0 <= s.length <= 5 * 104
s consists of English letters, digits, symbols and spaces.
s 由英文字母、數字、符號和空格組成。
*/
export function lengthOfLongestSubstring(s: string): number {
  const map = new Map<string, number>() // key,idx
  let maxLength = 0
  let l = 0
  for (let r = 0; r < s.length; r++) {
    // l r 區間有重複的值
    if (map.has(s[r]) && map.get(s[r])! >= l) {
      l = map.get(s[r])! + 1
    }
    map.set(s[r], r)
    maxLength = Math.max(r - l + 1, maxLength)
  }
  return maxLength
}
/*
你要找的是「最長的、不包含重複字元的連續子字串」。
注意是 substring（連續），不是 subsequence（可跳著取）。
用兩個指標（例如 left、right）表示目前視窗的範圍。
視窗內要保證「沒有重複字元」。
如果發現重複，就要移動 left 把重複的字元排除出去。
你可以用一個集合（Set）或 Map 來記錄當前視窗中有哪些字元。
這樣能在 O(1) 時間檢查「這個字元有沒有出現過」。
因為每個字元最多被左右指標各掃一次，
所以整體時間複雜度是 O(n)。
*/
