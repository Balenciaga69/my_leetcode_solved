namespace lc0005 {
  function longestPalindrome(s: string): string {
    const len = s.length;
    if (len < 2) return s;
    // * * * * *  * * * * *
    let maxLen = 1;
    let begin = 0;
    const dp = new Array(len).fill(0).map((_) => new Array(len).fill(false));
    for (let i = 0; i < len; i++) dp[i][i] = true;
    // * * * * *  * * * * *
    // L = 長度
    for (let L = 2; L <= len; L++) {
      for (let i = 0; i < len; i++) {
        let j = L + i - 1;
        if (j >= len) break;
        // * * * * * A * * * * *
        if (s[i] !== s[j]) dp[i][j] = false;
        else {
          // * * * * * B * * * * *
          if (j - i < 3) {
            dp[i][j] = true;
          } else {
            dp[i][j] = dp[i + 1][j - 1];
          }
          // * * * * * B * * * * *
        }
        // * * * * * A * * * * *
      }
    }
  }
}
let xs = [1, 2, 3] as const;
