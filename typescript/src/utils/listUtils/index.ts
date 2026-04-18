/**
 * 單向鏈結串列節點定義。
 */
export class ListNode {
  val: number
  next: ListNode | null

  constructor(val?: number, next?: ListNode | null) {
    this.val = val ?? 0
    this.next = next ?? null
  }
}

/**
 * 從陣列建立鏈結串列，並可選擇建立循環結構。
 * @param values - 節點值陣列。
 * @param pos - 尾節點指向的索引位置（0 起算），設定 -1 代表不建立循環。
 * @returns 鏈結串列的頭節點。
 */
export function createLinkedList(values: number[], pos: number = -1): ListNode | null {
  if (values.length === 0) return null
  const nodes = values.map((v) => new ListNode(v))
  for (let i = 0; i < nodes.length - 1; i++) {
    nodes[i].next = nodes[i + 1]
  }
  if (pos >= 0 && pos < nodes.length) {
    nodes[nodes.length - 1].next = nodes[pos]
  }
  return nodes[0]
}

export function linkedListToArray(head: ListNode | null, limit = 100): number[] {
  const res: number[] = []
  const visited = new Set<ListNode>()
  while (head && !visited.has(head) && res.length < limit) {
    res.push(head.val)
    visited.add(head)
    head = head.next
  }
  return res
}
