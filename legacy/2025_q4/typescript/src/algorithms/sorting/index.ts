/**
 * Bubble Sort
 * 時間複雜度: O(n^2)
 */
export function bubbleSort(arr: number[]): number[] {
  const res = [...arr]
  const lastIdx = res.length - 1
  for (let i = 0; i < lastIdx; i++) {
    for (let j = 0; j < lastIdx - i; j++) {
      if (res[j] > res[j + 1]) {
        // Swap
        ;[res[j], res[j + 1]] = [res[j + 1], res[j]]
      }
    }
  }
  return res
}

/**
 * Insertion Sort
 * 時間複雜度: O(n^2)
 */
export function insertionSort(arr: number[]): number[] {
  const res = [...arr]
  for (let i = 1; i < res.length; i++) {
    let key = res[i]
    let j = i - 1
    while (j >= 0 && res[j] > key) {
      res[j + 1] = res[j]
      j--
    }
    res[j + 1] = key
  }
  return res
}

/**
 * Selection Sort
 * 時間複雜度: O(n^2)
 */
export function selectionSort(arr: number[]): number[] {
  const res = [...arr]
  for (let i = 0; i < res.length - 1; i++) {
    let minIdx = i
    for (let j = i + 1; j < res.length; j++) {
      if (res[j] < res[minIdx]) {
        minIdx = j
      }
    }
    if (minIdx !== i) {
      ;[res[i], res[minIdx]] = [res[minIdx], res[i]]
    }
  }
  return res
}
