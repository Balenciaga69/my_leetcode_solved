package q0001

/*
  - 給定一個名為 nums 的整數陣列以及一個名為 target 的整數，
    回傳陣列中兩個數字的索引（indices），這兩個數字加起來等於 target。

  - 你可以假設每個輸入都恰好有一個解決方案，並且你不能重複使用相同的元素。

  - 你可以用任何順序回傳答案。

  - 分類: Array, Hash Table
*/

func mySolution(nums []int, target int) []int {
	hashTable := make(map[int]int) // key: 實際數字, value: 索引
	for xIdx, xVal := range nums {
		yVal := target - xVal
		yIdx, found := hashTable[yVal]
		if found {
			return []int{xIdx, yIdx}
		}
		hashTable[xVal] = xIdx
	}
	return nil
}

func twoSum(nums []int, target int) []int {
	return mySolution(nums, target)
}
