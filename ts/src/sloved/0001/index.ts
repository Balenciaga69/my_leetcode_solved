/*
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.
*/
export function twoSum(nums: number[], target: number): number[] {
  return exe1(nums, target)
}

/**
 * Date: 2026-01-13
 * Time spent: 10 minutes
 */
function exe1(nums: number[], target: number): number[] {
  const map = new Map<number, number>()
  for (let i = 0; i < nums.length; i++) {
    const num1 = nums[i]
    const num2 = target - num1
    if (map.has(num2)) return [i, map.get(num2)!]
    map.set(num1, i)
  }
  return [-1, -1]
}
