import { lengthOfLongestSubstring } from './index'

describe('lengthOfLongestSubstring', () => {
  it('應該返回最長不重複子字串的長度 - 範例 1', () => {
    const s = 'abcabcbb'
    const result = lengthOfLongestSubstring(s)
    expect(result).toBe(3)
  })

  it('應該返回最長不重複子字串的長度 - 範例 2', () => {
    const s = 'bbbbb'
    const result = lengthOfLongestSubstring(s)
    expect(result).toBe(1)
  })

  it('應該返回最長不重複子字串的長度 - 範例 3', () => {
    const s = 'pwwkew'
    const result = lengthOfLongestSubstring(s)
    expect(result).toBe(3)
  })

  it('abba', () => {
    const s = 'abba'
    const result = lengthOfLongestSubstring(s)
    expect(result).toBe(2)
  })
  it('應該處理空字串', () => {
    const s = ''
    const result = lengthOfLongestSubstring(s)
    expect(result).toBe(0)
  })

  it('應該處理單字符字串', () => {
    const s = 'a'
    const result = lengthOfLongestSubstring(s)
    expect(result).toBe(1)
  })

  it('應該處理包含重複字符的字串', () => {
    const s = 'aab'
    const result = lengthOfLongestSubstring(s)
    expect(result).toBe(2)
  })
})
