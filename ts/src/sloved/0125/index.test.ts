import { isPalindrome } from './index'

describe('isPalindrome', () => {
  it('應該正確判斷回文 - 範例 1', () => {
    const s = 'A man, a plan, a canal: Panama'
    const result = isPalindrome(s)
    expect(result).toBe(true)
  })

  it('應該正確判斷回文 - 範例 2', () => {
    const s = 'race a car'
    const result = isPalindrome(s)
    expect(result).toBe(false)
  })

  it('應該處理空字串', () => {
    const s = ' '
    const result = isPalindrome(s)
    expect(result).toBe(true)
  })

  it('應該處理只有非字母數字的字串', () => {
    const s = '.,,,,'
    const result = isPalindrome(s)
    expect(result).toBe(true)
  })

  it('應該處理單一字母', () => {
    const s = 'a'
    const result = isPalindrome(s)
    expect(result).toBe(true)
  })

  it('應該處理數字回文', () => {
    const s = '12321'
    const result = isPalindrome(s)
    expect(result).toBe(true)
  })

  it('應該處理混合大小寫', () => {
    const s = 'AbBa'
    const result = isPalindrome(s)
    expect(result).toBe(true)
  })
})
