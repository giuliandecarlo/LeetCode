class TreeNode(object):
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right
class Solution(object):
    def isSymmetric(self, root):
        def isSym(left, right):
            if not left and not right:
                return True
            if not left or not right or left.val != right.val:
                return False
            return(isSym(left.left,right.right) and isSym(right.left,left.right))
        return isSym(root.left,root.right)