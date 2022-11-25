namespace lc2007 {
  function findOriginalArray(ary: number[]): number[] {
    ary.sort((a, b) => a - b);
    // * * * * * map 限縮 查找範圍 * * * * *
    const hashMap = new Map<number, number>();
    let result: number[] = [];
    ary.forEach((key) => {
      const times = hashMap.get(key) || 0;
      hashMap.set(key, times + 1);
    });
    hashMap.forEach((times, key) => {
      // * * * * *  * * * * *
      if (times <= 0) return;
      // * * * * *  * * * * *
      if (key === 0) {
        if (times % 2 === 0) repeatPush(key, times / 2);
        return;
      }
      // * * * * *  * * * * *
      const x2Times = hashMap.get(key * 2) || 0;
      if (x2Times - times > -1) {
        hashMap.set(key * 2, x2Times - times);
        repeatPush(key, times);
      }
      // * * * * *  * * * * *
    });
    return result.length * 2 === ary.length ? result : [];
    // * * * * *  * * * * *
    function repeatPush(key: number, times: number) {
      result = [...result, ...new Array(times).fill(key)];
    }
  }
  const x = findOriginalArray([0, 0, 0, 0]);
  console.log(x);
}
