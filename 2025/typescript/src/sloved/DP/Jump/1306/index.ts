/*
未完成
給定一個非負整數陣列 arr，你一開始位於索引 start。
當你在索引 i 時，你可以跳到 i + arr[i] 或 i - arr[i]。
請判斷是否可以到達陣列中任意一個值為 0 的索引。

注意：你不能跳出陣列範圍。

範例 1：
輸入：arr = [4,2,3,0,3,1,2], start = 5
輸出：true
解釋：
所有可以到達值為 0 的索引 3 的路徑：
index 5 -> index 4 -> index 1 -> index 3
index 5 -> index 6 -> index 4 -> index 1 -> index 3

範例 2：
輸入：arr = [4,2,3,0,3,1,2], start = 0
輸出：true
解釋：
一種到達值為 0 的索引 3 的路徑：
index 0 -> index 4 -> index 1 -> index 3

範例 3：
輸入：arr = [3,0,2,1,2], start = 2
輸出：false
解釋：沒有辦法到達值為 0 的索引 1。

限制：
1 <= arr.length <= 5 * 10^4
0 <= arr[i] < arr.length
0 <= start < arr.length
*/

export function canReach(arr: number[], start: number): boolean {
  // TODO: 請實作
  return false;
}
