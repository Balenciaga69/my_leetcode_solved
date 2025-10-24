// Closure（閉包）= 函式 + 函式能夠記住的外部變數環境。
/* GPT 示範
function outer() {
  let count = 0 // 外層變數
  function inner() {
    count++
    console.log(count)
  }
  return inner // 回傳內部函式
}

// React 工作上 使用的 CustomizeHook 自己自訂給 Component用到的Hooks 常常用到 Closure
*/
function SaveAsCache(fn: (x: number) => number) {
  const cache: Record<number, number> = {}
  return function (x: number) {
    if (x in cache) {
      console.info('xZx 取快取', x)
      return cache[x]
    }
    console.log('xZx 計算:', x)
    const result = fn(x)
    cache[x] = result
    return result
  }
}

const AxA = SaveAsCache((x: number) => x * x)
console.log(AxA(4)) // 計算
console.log(AxA(4)) // 取快取
console.log(AxA(33)) // 取快取
