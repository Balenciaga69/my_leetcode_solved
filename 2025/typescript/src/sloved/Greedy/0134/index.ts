/*
Tags: Greedy, Array, Simulation
Date: 2025-10-XX
TimeSpent: xx mins
---
給定兩個長度相同的整數陣列 gas 和 cost。
- gas[i] 代表你在第 i 個加油站能取得的汽油量。
- cost[i] 代表從第 i 個加油站開到下一個加油站所需消耗的汽油量。
你的車子有無限大的油箱，但初始油量為 0。  
請問是否存在一個加油站索引 i，讓你能從那個站出發，  
依序繞行整個環狀路線一圈回到原點，而中途油量永遠不會變成負數？
若存在，回傳該起點索引 i；若不存在，回傳 -1。
---
輸入: gas = [1,2,3,4,5], cost = [3,4,5,1,2]  
輸出: 3  
解釋: 從第 3 個站出發：  
油量變化：0+4-1=3 → 3+5-2=6 → 6+1-3=4 → 4+2-4=2 → 2+3-5=0 → 成功回到起點
---
輸入: gas = [2,3,4], cost = [3,4,3]  
輸出: -1  
解釋: 無法繞一圈
---
限制條件
1 <= gas.length == cost.length <= 10^5  
0 <= gas[i], cost[i] <= 10^4
*/
export function canCompleteCircuit(gas: number[], cost: number[]): number {}
