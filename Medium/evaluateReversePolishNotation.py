def evalRPN(tokens):
    val=[]
    for el in tokens:
        if el =="+":
            val.append(val.pop() + val.pop())
        elif el =="-":
            val.append((-1*val.pop()) + val.pop())
        elif el =="*":
            val.append(val.pop() * val.pop())
        elif el =="/":
            a=val.pop()
            b=val.pop()
            val.append(int(float(b)/a))
        else:
            val.append(int(el))
    return val[-1]