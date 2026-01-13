// Given a string `s`, find the length of the "longest substring without duplicate characters".
/**
 * Date: 2026-01-13
 * Time spent: 11 minutes
 */
export function lengthOfLongestSubstring(s: string): number {
  const map = new Map<string, number>()
  let curMaxLen = 0
  let l = 0
  for (let r = 0; r < s.length; r++) {
    const str = s[r]
    const existed = map.has(str)
    if (existed) {
      l = Math.max(l, map.get(str)! + 1)
      map.set(str, r)
    } else {
      map.set(str, r)
    }
    curMaxLen = Math.max(curMaxLen, r - l + 1)
  }
  return curMaxLen
}
