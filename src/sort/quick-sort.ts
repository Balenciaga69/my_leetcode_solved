namespace QuickSort {
  function quickSort(array: number[], left: number, right: number) {
    if (left >= right) return array;
    let slow = left;
    for (let fast = left; fast < right; fast++) {
      if (array[fast] <= array[right]) {
        swap(array, slow, fast);
        slow = slow + 1;
      }
    }
    swap(array, slow, right);
    quickSort(array, left, slow - 1);
    quickSort(array, slow + 1, right);
    return array;
  }
  function swap(array: number[], x: number, y: number) {
    const temp = array[x];
    array[x] = array[y];
    array[y] = temp;
  }
  const input = [3, 2, 5, 0, 1, 8, 7, 6, 9, 4];
  const output = quickSort(input, 0, input.length - 1);
}
