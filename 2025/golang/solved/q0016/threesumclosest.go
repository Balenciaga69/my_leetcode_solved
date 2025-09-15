package q0016

import (
	"math"
	"sort"
)

/*
- Given an integer array nums of length n and an integer target, find three integers in nums such that the sum is closest to target.
- Return the sum of the three integers.
- You may assume that each input would have exactly one solution.

Topics: Array, Two Pointers, Sorting

Constraints:
	3 <= nums.length <= 500
	-10^3 <= nums[i] <= 10^3
	-10^4 <= target <= 10^4
*/

func threeSumClosest(nums []int, target int) int {
	return mySolution(nums, target)
}

/*
避免 時間複雜度 O(n^3) 所以必須使用排序 + 雙指標讓時間複雜度降到 O(n^2)
*/
func mySolution(nums []int, target int) int {
	sort.Ints(nums)

	// 這是我們需要的最終回傳值變數
	returnSum := nums[0] + nums[1] + nums[2]
	// len(nums)-2 是因為我們需要三個數字, 所以 i 最多只能到倒數第三個 舉例: [甲, 乙, 丙, 丁] i 最多只能到 乙
	for i := 0; i < len(nums)-2; i++ {
		l := i + 1
		r := len(nums) - 1
		// 當 l < r 時, 代表還有組合可以嘗試
		for l < r {
			currSum := nums[i] + nums[l] + nums[r]
			if currSum == target {
				return currSum
			}
			// 如果目前的組合比之前的組合更接近 target, 就更新 closestSum
			if math.Abs(float64(currSum-target)) < math.Abs(float64(returnSum-target)) {
				returnSum = currSum
			}
			// 如果 比 目標 小 代表 需要更大的數字, 所以 l++
			// 如果 比 目標 大 代表 需要更小的數字, 所以 r--
			if currSum < target {
				l++
			} else {
				r--
			}
		}
	}
	return returnSum
}
