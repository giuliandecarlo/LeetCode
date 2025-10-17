def addBinary(a,b):
    a = list(a)
    b= list(b)
    sum = ""
    carry = 0
    while a or b or carry:
        if a:
            carry += int(a.pop())
        if b:
            carry += int(b.pop())
        sum += str(carry % 2)
        carry = carry // 2
    return(sum[::-1])