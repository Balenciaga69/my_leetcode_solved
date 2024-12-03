from typing import List, Optional
from dataStructure.treeNode import TreeNode, listToTree

l1: list[int | None] = [1, None, 2, 3]
l2: list[int | None] = [1, 2, 3, 4, 5, None, 8, None, None, 6, 7, 9]


root1 = listToTree(l1)


class Solution:
    def preorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        return []


Solution().preorderTraversal(root=root1)
