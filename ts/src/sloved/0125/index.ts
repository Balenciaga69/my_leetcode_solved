export function isPalindrome(s: string): boolean {
  return method2(s)
}
/**
 * Date: 2026-01-20
 * Time spent: 24 mins
 */
const method1 = (s: string): boolean => {
  let [l, r] = [0, s.length - 1]
  while (l <= r) {
    if (!isAlphaAndNum(s[l])) {
      l++
      continue
    }
    if (!isAlphaAndNum(s[r])) {
      r--
      continue
    }
    if (s[l].toLowerCase() !== s[r].toLowerCase()) return false
    l++
    r--
  }
  return true
}
/**
 * Date: 2026-01-20
 * Time spent: 3 mins
 */
const method2 = (s: string): boolean => {
  const list: string[] = []
  for (let c of s) {
    if (isAlphaAndNum(c)) list.push(c.toLowerCase())
  }
  return list.join('') === list.reverse().join('')
}

const isAlphaAndNum = (char: string) => {
  return ('a' <= char && char <= 'z') || ('A' <= char && char <= 'Z') || ('0' <= char && char <= '9')
}
