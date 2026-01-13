import { longestPalindrome } from './index'

describe('longestPalindrome', () => {
  it('應該返回最長回文子字串 - 範例 1', () => {
    const s = 'babad'
    const result = longestPalindrome(s)
    expect(result).toBe('bab') // 或 'aba'，但測試固定為 'bab'
  })

  it('應該返回最長回文子字串 - 範例 2', () => {
    const s = 'cbbd'
    const result = longestPalindrome(s)
    expect(result).toBe('bb')
  })

  it('應該處理空字串', () => {
    const s = ''
    const result = longestPalindrome(s)
    expect(result).toBe('')
  })

  it('應該處理單字符字串', () => {
    const s = 'a'
    const result = longestPalindrome(s)
    expect(result).toBe('a')
  })

  it('應該處理全相同字符字串', () => {
    const s = 'aaa'
    const result = longestPalindrome(s)
    expect(result).toBe('aaa')
  })

  it('應該處理沒有回文的情況', () => {
    const s = 'abc'
    const result = longestPalindrome(s)
    expect(['a', 'b', 'c']).toContain(result) // 任意單字符
  })
})
