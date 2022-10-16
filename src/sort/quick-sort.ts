export class QuickSort {
  constructor() {}
  do() {
    function quickSort(arr: number[], l: number, r: number) {
      if (l >= r) return arr;
      let i = l;
      for (let j = l; j < r; j++) {
        if (arr[j] <= arr[r]) {
          swap(arr, i, j);
          i++;
        }
      }
      swap(arr, i, r);
      quickSort(arr, l, i - 1);
      quickSort(arr, i + 1, r);
      return arr;
    }
    function swap(arr: number[], x: number, y: number) {
      const temp = arr[x];
      arr[x] = arr[y];
      arr[y] = temp;
    }

    const input = [3, 2, 5, 0, 1, 8, 7, 6, 9, 4];
    const output = quickSort(input, 0, input.length - 1);
    return output;
  }
}
