/**
 * 將邊列表轉換成無向圖的鄰接串列。
 * @param edges - 邊列表，每個元素格式為 [u, v]。
 * @returns 無向圖的鄰接串列映射。
 */
export function createAdjList(edges: number[][]): Map<number, number[]> {
  const graph = new Map<number, number[]>()
  for (const [u, v] of edges) {
    if (!graph.has(u)) graph.set(u, [])
    if (!graph.has(v)) graph.set(v, [])
    graph.get(u)!.push(v)
    graph.get(v)!.push(u) // 無向圖
  }
  return graph
}
