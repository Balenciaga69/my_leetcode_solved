namespace MergeSort {
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
    let lIdx = 0;
    let rIdx = 0;
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
}
