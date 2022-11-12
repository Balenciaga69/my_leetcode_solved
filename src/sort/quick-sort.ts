namespace QuickSort {
  let count = 0;
  function quickSort(array: number[], left: number, right: number) {
    if (left >= right) return array;

    let slow = left;
    for (let fast = left; fast < right; fast++) {
      count++;
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
  const input = [1, 3, 2];
  const output = quickSort(input, 0, input.length - 1);
  console.log(`正在測試...`, count);
}
