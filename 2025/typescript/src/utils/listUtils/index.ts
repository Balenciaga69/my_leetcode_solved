/**
 * Definition for singly-linked list.
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
 * Create a linked list from an array and optional cycle position.
 * @param values - The array of node values.
 * @param pos - The index of the node (0-based) to which the tail connects. Use -1 for no cycle.
 * @returns The head of the linked list.
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
