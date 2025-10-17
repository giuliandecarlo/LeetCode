def pascalTriangle(numRows):
    res = []
    for i in range(numRows+1):
        line = []
        for y in range(i):
            if y==0 or y==i-1:
                line.append(1)
            else:
                line.append(res[-1][y-1]+res[-1][y])
        if i!=0:
            res.append(line)
    return res