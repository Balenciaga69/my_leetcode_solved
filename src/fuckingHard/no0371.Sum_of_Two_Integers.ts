namespace lc0371 {
  function getSum(a: number, b: number): number {
    let count = 0;
    while (b != 0) {
      console.log(++count);
      const carry = (a & b) << 1;
      a = a ^ b;
      b = carry;
    }
    return a;
  }
  getSum(7, 18);
}
