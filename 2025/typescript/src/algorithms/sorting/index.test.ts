import { bubbleSort, insertionSort, selectionSort } from './index'

describe('Bubble Sort', () => {
  test('基本排序', () => {
    expect(bubbleSort([5, 2, 9, 1, 5, 6])).toEqual([1, 2, 5, 5, 6, 9])
    expect(bubbleSort([])).toEqual([])
    expect(bubbleSort([1])).toEqual([1])
  })
})

describe('Insertion Sort', () => {
  test('基本排序', () => {
    expect(insertionSort([5, 2, 9, 1, 5, 6])).toEqual([1, 2, 5, 5, 6, 9])
    expect(insertionSort([])).toEqual([])
    expect(insertionSort([1])).toEqual([1])
  })
})

describe('Selection Sort', () => {
  test('基本排序', () => {
    expect(selectionSort([5, 2, 9, 1, 5, 6])).toEqual([1, 2, 5, 5, 6, 9])
    expect(selectionSort([])).toEqual([])
    expect(selectionSort([1])).toEqual([1])
  })
})
