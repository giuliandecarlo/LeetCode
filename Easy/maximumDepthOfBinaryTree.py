class TreeNode(object):
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right
class Solution(object):
    def maxDepth(self, root):
        def depth(root,d):
            if not root:
                return d
            return max(depth(root.left,d+1),depth(root.right,d+1))
        return depth(root,0)