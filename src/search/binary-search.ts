namespace BinarySearch {
  function binarySearch(arr: number[], target: number): boolean {
    const m = Math.floor(arr.length / 2);
    if (arr[m] === target) return true;
    if (arr.length === 1) return false;
    if (target > arr[m]) {
      return binarySearch(arr.slice(m), target);
    } else {
      return binarySearch(arr.slice(0, m), target);
    }
  }
  let input = [5, 7, 3, 5, 8, 9, 11, 212, 4, 59, 96, 23, 7, 17, 55];
  input.sort((a, b) => a - b);
  const output = binarySearch(input, 5);
  console.log(output);
}
