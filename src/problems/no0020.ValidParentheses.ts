namespace lc0020 {
  function isValid(s: string): boolean {
    if (s.length <= 1) return false;
    const A = ["(", "{", "["] as const;
    const B = [")", "}", "]"] as const;
    const stack: string[] = [];
    for (let target of s.split("")) {
      if (A.find((e) => e === target)) {
        stack.push(target);
      } else {
        let idx = B.findIndex((e) => e === target);
        if (A[idx] === stack[stack.length - 1]) {
          stack.pop();
        } else {
          return false;
        }
      }
    }
    // 有殘留 括號
    return stack.length === 0;
  }
  const s = "(([]({})))";
  const out = isValid(s);
  console.log(`正在測試...`, out);
}
