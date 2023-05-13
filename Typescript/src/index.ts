function removeElement(nums: number[], val: number): number {
  let result = 0
  let originalLength = nums.length
  for (let i = nums.length - 1; i > -1; i--) {
    if (nums[i] === val) {
      nums.splice(i, 1)
      result++
    }
  }
  return originalLength - result
}

console.log(removeElement([0, 1, 2, 2, 3, 0, 4, 2], 2))
