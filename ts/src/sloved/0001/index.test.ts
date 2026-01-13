import { twoSum } from './index'

describe('twoSum', () => {
  it('應該返回兩個數字的索引，使它們加起來等於目標值', () => {
    const nums = [2, 7, 11, 15]
    const target = 9
    const result = twoSum(nums, target).sort((a, b) => a - b)
    expect(result).toEqual([0, 1])
  })

  it('應該處理不同的索引順序', () => {
    const nums = [3, 2, 4]
    const target = 6
    const result = twoSum(nums, target)
    expect(result.sort()).toEqual([1, 2])
  })

  it('應該處理包含負數的數組', () => {
    const nums = [-1, -2, -3, -4, -5]
    const target = -8
    const result = twoSum(nums, target)
    expect(result.sort()).toEqual([2, 4])
  })
})
