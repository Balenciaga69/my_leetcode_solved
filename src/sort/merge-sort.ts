export class mergeSort {
  constructor() {}
  do() {
    function divide(array: number[]): number[] {
      const length = array.length;
      if (length === 1) return array;
      const m = (length / 2) | 0;
      const l = array.slice(0, m);
      const r = array.slice(m);
      let result = merge(divide(l), divide(r));
      return result;
    }
    function merge(lAry: number[], rAry: number[]) {
      const result: number[] = [];
      let lIdx = 0,
        rIdx = 0;
      while (lIdx < lAry.length && rIdx < rAry.length) {
        const L = lAry[lIdx];
        const R = rAry[rIdx];
        if (L < R) {
          result.push(L);
          lIdx++;
        } else {
          result.push(R);
          rIdx++;
        }
      }
      return [...result, ...lAry.slice(lIdx), ...rAry.splice(rIdx)];
    }
    const input = [4, 2, 3, 6, 8];
    const output = divide(input);
    return output;
  }
}

// 合併排序（英語：Merge sort），
// 是建立在合併操作上的一種有效的排序演算法，
// 效率為 n log n）。
// 1945年由約翰·馮·紐曼首次提出。該演算法是採用分治法（Divide and Conquer）的一個非常典型的應用，且各層分治遞迴可以同時進行。
