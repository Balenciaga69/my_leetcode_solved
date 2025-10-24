/*
Given an [unsorted array] of integers nums, return the length of the [longest consecutive elements sequence].
You must write an algorithm that runs in O(n) time. [只能觸發 n 次]

Constraints:
0 <= nums.length <= 105
-109 <= nums[i] <= 109
*/

/*
題目要求在「O(n)」時間內完成，這是關鍵。
代表不能用排序（那是 O(n log n)）。
要想辦法一次掃過資料，就能判斷所有連續區段。
---
這題實際上是在考「HashSet」或等價結構的靈活應用。
利用集合的 O(1) 查找特性，快速判斷某數是否存在。
關鍵技巧是：只從「序列開頭」開始找連續段，避免重複計算。
---
判斷一個數是否是連續段開頭的條件：前一個數不存在。
一旦確定是開頭，再往後逐個延伸，直到斷開。
這樣可確保整體只掃過每個數一次。
*/
export function longestConsecutive(nums: number[]): number {
  const set = new Set<number>()
  nums.forEach((num) => {
    set.add(num)
  })

  let maxLength = 0
  set.forEach((num) => {
    if (!set.has(num - 1)) {
      let curr = num
      let currLength = 1
      while (set.has(curr + currLength)) {
        currLength++
      }
      maxLength = Math.max(currLength, maxLength)
    }
  })
  return maxLength
}
