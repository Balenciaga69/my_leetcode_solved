import { arrayToBST, TreeNode } from "../../data-structure/class.treeNode";

namespace lc0572 {
  function isSubtree(root: TreeNode | null, subRoot: TreeNode | null): boolean {
    return false;
  }
  const a1 = arrayToBST([3, 4, 5, 1, 2]);
  const a2 = arrayToBST([4, 1, 2]);
  isSubtree(a1, a2);
}
// let x ='523'.sea
