/**
 * LeetCode 1. Two Sum
 * 回傳兩個數字的索引，使其相加等於 target
 */
export function twoSum(nums: number[], target: number): number[] {
  const map = new Map<number, number>()
  for (let i = 0; i < nums.length; i++) {
    const complement = target - nums[i]
    if (map.has(complement)) {
      return [map.get(complement) as number, i]
    }
    map.set(nums[i], i)
  }
  return []
}
