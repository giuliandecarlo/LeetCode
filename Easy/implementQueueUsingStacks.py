class MyQueue(object):

    def __init__(self):
        self.stack = []

    def push(self, x):
        self.stack.append(x)
        

    def pop(self):
        return self.stack.pop(0)

    def peek(self):
        return self.stack[0]
        

    def empty(self):
        if self.stack:
            return False
        else:
            return True
        


# Your MyQueue object will be instantiated and called as such:
# obj = MyQueue()
# obj.push(x)
# param_2 = obj.pop()
# param_3 = obj.peek()
# param_4 = obj.empty()