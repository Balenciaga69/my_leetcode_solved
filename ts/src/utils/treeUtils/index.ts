/**
 * Definition for a binary tree node.
 */
export class TreeNode {
  val: number
  left: TreeNode | null
  right: TreeNode | null

  constructor(val?: number, left?: TreeNode | null, right?: TreeNode | null) {
    this.val = val ?? 0
    this.left = left ?? null
    this.right = right ?? null
  }
}

/**
 * Create a binary tree from an array in level-order form.
 * @param values - Array of values where `null` represents missing nodes.
 * @returns Root node of the binary tree.
 */
export function createBinaryTree(values: (number | null)[]): TreeNode | null {
  if (!values.length || values[0] === null) return null

  const root = new TreeNode(values[0])
  const queue: TreeNode[] = [root]
  let i = 1

  while (queue.length && i < values.length) {
    const current = queue.shift()!
    if (values[i] !== null && i < values.length) {
      current.left = new TreeNode(values[i]!)
      queue.push(current.left)
    }
    i++
    if (values[i] !== null && i < values.length) {
      current.right = new TreeNode(values[i]!)
      queue.push(current.right)
    }
    i++
  }

  return root
}

export function binaryTreeToArray(root: TreeNode | null): (number | null)[] {
  if (!root) return []
  const res: (number | null)[] = []
  const queue: (TreeNode | null)[] = [root]

  while (queue.length) {
    const node = queue.shift()
    if (node) {
      res.push(node.val)
      queue.push(node.left)
      queue.push(node.right)
    } else {
      res.push(null)
    }
  }

  // 去掉尾端多餘的 null
  while (res[res.length - 1] === null) res.pop()
  return res
}
