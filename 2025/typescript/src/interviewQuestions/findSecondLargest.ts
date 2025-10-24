// Find second largest within O(n) complexity.
function findSecondLargest(sequence: number[]) {
  let number1 = -Infinity
  let number2 = -Infinity
  for (let i = 0; i < sequence.length; i++) {
    const currNum = sequence[i]
    // 比第一名大 把第一名擠下去 連帶第二名變第三名
    if (currNum > number1) {
      ;[number1, number2] = [currNum, number1]
    } else {
      // 比第一名小 比第二名大
      if (currNum < number1 && currNum > number2) {
        number2 = currNum
      }
    }
  }
  return number2
}
console.info('xZx ', findSecondLargest([3, 3, 2, 1]))
console.info('xZx ', findSecondLargest([8, 9, 4, 2, 1]))
