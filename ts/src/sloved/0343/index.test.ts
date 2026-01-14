import { integerBreak } from './index'

describe('integerBreak', () => {
  it('Example 1', () => {
    const n = 2
    const result = integerBreak(n)
    expect(result).toBe(1)
  })

  it('Example 2', () => {
    const n = 10
    const result = integerBreak(n)
    expect(result).toBe(36)
  })
})
