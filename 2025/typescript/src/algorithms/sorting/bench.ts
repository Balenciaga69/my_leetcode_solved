import { bubbleSort, insertionSort, selectionSort } from './index'

function randomArray(len: number, min = 0, max = 100000): number[] {
  return Array.from({ length: len }, () => Math.floor(Math.random() * (max - min + 1)) + min)
}

function isSortedEqual(a: number[], b: number[]): boolean {
  return JSON.stringify(a) === JSON.stringify(b)
}

function testSort(name: string, sortFn: (arr: number[]) => number[], arr: number[], expected: number[]) {
  const t0 = performance.now()
  const result = sortFn(arr)
  const t1 = performance.now()
  console.log(`${name}: ${(t1 - t0).toFixed(2)} ms, 正確: ${isSortedEqual(result, expected)}`)
}

function runBench() {
  const sizes = [9000, 15000] // O(n^2) 容忍 5 秒內
  for (const size of sizes) {
    const arr = randomArray(size)
    const expected = [...arr].sort((a, b) => a - b)
    console.log(`\nArray size: ${size}`)

    testSort('Bubble Sort', bubbleSort, arr, expected)
    testSort('Insertion Sort', insertionSort, arr, expected)
    testSort('Selection Sort', selectionSort, arr, expected)
  }
}

runBench()
